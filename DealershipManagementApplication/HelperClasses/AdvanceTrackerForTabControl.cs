using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DealershipManagementApplication.HelperClasses
{
    
    public class AdvanceTrackerForTabControl : ContentControl
    {
        public bool IsChanged
        {
            get { return (bool)GetValue(IsChangedProperty); }
            set { SetValue(IsChangedProperty, value); }
        }
        public static readonly DependencyProperty IsChangedProperty =
            DependencyProperty.Register("IsChanged", typeof(bool), typeof(AdvanceTrackerForTabControl), new PropertyMetadata(false));

        public static string GetProperty(DependencyObject obj)
        {
            return (string)obj.GetValue(PropertyProperty);
        }
        public static void SetProperty(DependencyObject obj, string value)
        {
            obj.SetValue(PropertyProperty, value);
        }
        public static readonly DependencyProperty PropertyProperty =
            DependencyProperty.RegisterAttached("Property", typeof(string), typeof(AdvanceTrackerForTabControl), new PropertyMetadata(null));

        private readonly Dictionary<PropertyWatcher1, object> trackedPropertySnapshot = new Dictionary<PropertyWatcher1, object>();
        private readonly List<PropertyWatcher1> changedProperties = new List<PropertyWatcher1>();
        private readonly object nullProperty = new object();

        public AdvanceTrackerForTabControl()
        {
            Initialized += (s, e) =>
            {
                var content = Content as DependencyObject;
                if (content != null)
                    WalkDownVisualTree(content);
            };
        }

        public void AcceptChanges()
        {
            changedProperties.Clear();
            IsChanged = false;
        }

        public void ResetChanges()
        {
            trackedPropertySnapshot.Clear();
            AcceptChanges();

            var content = Content as DependencyObject;
            if (content != null)
                WalkDownVisualTree(content);
        }

        private void WalkDownVisualTree(DependencyObject current)
        {
            var property = current.ReadLocalValue(PropertyProperty);
            if (property != DependencyProperty.UnsetValue)
            {
                var frameworkElement = current as FrameworkElement;

                RegisterTrackedProperty(current, (string)property);
            }

            var count = VisualTreeHelper.GetChildrenCount(current);
            for (int i = 0; i < count; i++)
            {
                WalkDownVisualTree(VisualTreeHelper.GetChild(current, i));
            }
        }

        private void RegisterTrackedProperty(DependencyObject item, string propertyName)
        {
            var notifier = new PropertyWatcher1(item, propertyName);
            notifier.ValueChanged += TrackedPropertyChanged;
            //if (!trackedPropertySnapshot.ContainsKey(notifier))
            {
                trackedPropertySnapshot.Add(notifier, notifier.Value);
            }
        }

        private void TrackedPropertyChanged(object sender, EventArgs e)
        {
            var notifier = ((PropertyWatcher1)sender);

            var original = nullProperty;
            if (trackedPropertySnapshot.ContainsKey(notifier))
            {
                original = trackedPropertySnapshot[notifier] ?? nullProperty;

                //var original = trackedPropertySnapshot[notifier] ?? nullProperty;
                var current = notifier.Value ?? nullProperty;

                string sDataType = AddOnExtension.GetDataType((notifier.Source) as UIElement);

                if (sDataType == "C" || sDataType == "UCGLAccount")
                {
                    switch (sDataType)
                    {
                        case "C":
                            if ((original.ToString().Contains(",") || current.ToString().Contains(",")) && (!original.ToString().Replace(",", "").Equals(current.ToString().Replace(",", ""))))
                            {
                                if (!changedProperties.Contains(notifier))
                                    changedProperties.Add(notifier);                            
                            }else
                            {
                                changedProperties.Remove(notifier);
                            }
                            break;
                        case "UCGLAccount":

                            if (!(original == nullProperty || original.ToString() =="0" ? "" : original).Equals(current == nullProperty || current.ToString() == "0" ? "" : current) )
                                //&& !original.ToString().Replace("0", "").Equals(current.ToString().Replace("0", "")))
                            {
                                if (!changedProperties.Contains(notifier))
                                    changedProperties.Add(notifier);
                            }
                            else
                            {
                                changedProperties.Remove(notifier);
                            }
                            break;
                    }
                }               
                else if (!original.Equals(current))
                {
                    if (!changedProperties.Contains(notifier))
                        changedProperties.Add(notifier);
                }
                else
                    changedProperties.Remove(notifier);

                IsChanged = changedProperties.Count != 0;
            }
        }
    }
}
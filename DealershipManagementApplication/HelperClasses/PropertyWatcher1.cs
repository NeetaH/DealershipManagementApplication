using System;
using System.Windows;
using System.Windows.Data;

namespace DealershipManagementApplication.HelperClasses
{
    
    public class PropertyWatcher1 : DependencyObject
    {
        public DependencyObject Source { get; protected set; }

        public PropertyWatcher1(DependencyObject source, string propertyName)
        {
            Source = source;

            var path = new PropertyPath(propertyName);
            var binding = new Binding { Path = path, Mode = BindingMode.OneWay, Source = source };
            BindingOperations.SetBinding(this, ValueProperty, binding);
        }
        
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(object), typeof(PropertyWatcher1), new PropertyMetadata(null, OnPropertyChanged));

        private static void OnPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var notifier = (PropertyWatcher1)sender;
            notifier.ValueChanged(notifier, EventArgs.Empty);
        }

        public object Value
        {
            get { return GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public event EventHandler ValueChanged = delegate { };
    }
}
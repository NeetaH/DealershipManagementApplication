  using System.Windows;


namespace DealershipManagementApplication.HelperClasses
{
   
    public class AddOnExtension : DependencyObject
    {
        public static readonly DependencyProperty DataTypeProperty = DependencyProperty.RegisterAttached("DataType",
            typeof(string), typeof(AddOnExtension), new PropertyMetadata(default(string)));

        public static string GetDataType(UIElement target)
        {
            return (string)target.GetValue(DataTypeProperty);
        }

        public static void SetDataType(UIElement target, string value)
        {
            target.SetValue(DataTypeProperty, value);
        }
    }
}

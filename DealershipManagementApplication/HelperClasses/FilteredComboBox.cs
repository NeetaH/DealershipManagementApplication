using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;

namespace DealershipManagementApplication.HelperClasses
{
    public class FilteredComboBox  :  ComboBox
    {

        public FilteredComboBox()
        {
            this.IsEditable = true;
            this.IsTextSearchEnabled = true;

            this.GotKeyboardFocus += new KeyboardFocusChangedEventHandler(FilteredComboBox_GotKeyboardFocus); 
            this.DropDownClosed += new EventHandler(FilteredComboBox_DropDownClosed);
            this.LostFocus += new RoutedEventHandler(FilteredComboBox_LostFocus);
        }

        void FilteredComboBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (this != null)
            {
                TextBox txt = this.Template.FindName("PART_EditableTextBox", this) as TextBox;

                if (txt != null)
                    txt.CharacterCasing = CharacterCasing.Upper;
            }
        }

        void FilteredComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (this != null)
            {
                TextBox txt = this.Template.FindName("PART_EditableTextBox", this) as TextBox;

                if (txt != null)
                    txt.ScrollToHome();
            }
        }

        void FilteredComboBox_LostFocus(object sender, EventArgs e)
        {
            if (this != null)
            {
                if (!this.IsKeyboardFocusWithin)
                {
                    TextBox txt = this.Template.FindName("PART_EditableTextBox", this) as TextBox;

                    if (txt != null)
                        txt.ScrollToHome();

                    if (this.SelectedIndex == -1)
                        this.Text = "";
                }
            }
        }

     
    }
}

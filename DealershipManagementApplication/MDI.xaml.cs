using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DealershipManagementApplication
{
    /// <summary>
    /// Interaction logic for MDI.xaml
    /// </summary>
    public partial class MDI : Window
    {
        public MDI()
        {
            InitializeComponent();
            //Doccontainer.ActiveDocumentChanged += new PropertyChangedCallback(Doccontainer_ActiveDocumentChanged);
        }

        //public void Doccontainer_ActiveDocumentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    if (e.NewValue != null && e.NewValue is FrameworkElement)//ooo
        //    {
        //        ActiveWindowDataContext = (e.NewValue as FrameworkElement).DataContext;
        //        ActiveForm = e.NewValue as FrameworkElement;

        //        CommonClass.Path = MenuMapper.GetMenuPathForStatusBar(ActiveForm.ToString());

        //        if (MenuMapper.CheckIfSmallMasterIsActive(ActiveForm.ToString()) == true)
        //            OnFormActive(this, new FormActiveEventArgs());
        //    }
        //}

        public void SetActiveDocument(UserControl UcItem)
        {
            Doccontainer.Items.Clear();
            Doccontainer.Items.Add(UcItem);
            if (UcItem != null)
            {
                DocumentContainer.SetMDIBounds(UcItem, new Rect(((this.ActualWidth - 493) / 2 < 0 ? 0 : (this.ActualWidth - 493) / 2), ((this.ActualHeight - 415) / 2 < 0 ? 0 : (this.ActualHeight - 415) / 2), 493, 415));
                DocumentContainer.SetHeader(UcItem, "About Us");
            }
            Doccontainer.ActiveDocument = UcItem;
        }
    }
}

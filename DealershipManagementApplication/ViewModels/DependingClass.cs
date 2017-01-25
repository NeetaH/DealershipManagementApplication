using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace DealershipManagementApplication.ViewModels
{
    class DependingClass
    {
    }
    //[ValueConversion(typeof(int), typeof(Brush))]
    public class SalesValueToColorConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int MyVal;
            decimal EstimatedValue;
            try
            {

                MyVal = int.Parse(value.ToString());
                EstimatedValue = decimal.Parse(value.ToString());

                int EstimateToInvoice = 2;

                //int LocID = int.Parse(SalesFrontCounterViewModel.ValConvertLocationID == "" ? "0" : SalesFrontCounterViewModel.ValConvertLocationID);

                int LocID = 1;

                int parm = int.Parse(parameter.ToString());

                if (parm == 1 && MyVal > 0)
                    return (MyVal == LocID ? Brushes.Black : Brushes.Red);

                if (parm == 1 && MyVal == 0)
                    return (MyVal == LocID ? Brushes.Black : Brushes.Blue);

                if (parm == 2)
                    return (MyVal == LocID ? System.Drawing.FontStyle.Italic : System.Drawing.FontStyle.Italic);

                if (parm == 3)
                    return (MyVal == EstimateToInvoice ? Brushes.Red : Brushes.Black);

                if (parm == 4)
                    return (EstimatedValue > 0 ? Brushes.Black : Brushes.Red);

                return System.Drawing.FontStyle.Italic;
            }
            catch
            {
                return System.Drawing.Brushes.Black;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    //[ValueConversion(typeof(dedcimal), typeof(char))]
    public class SalesValueToEncryptConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string retunrEncrypt = "******";
            string returnVal = value.ToString();
            if (value.ToString() == "")
                value = "0";

            decimal val = decimal.Parse(value.ToString().Replace(",", "").Replace(")", "").Replace("(", ""));

            try
            {
                //if (val != 0)
                //{
                //if (SalesFrontCounterViewModel.valEncrypt == 1)
                //    returnVal = retunrEncrypt.ToString();
                //else
                //    returnVal = value.ToString();
                //}
                return returnVal;
            }
            catch
            {
                return retunrEncrypt;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }


    }
}

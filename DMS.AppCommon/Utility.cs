using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DMS.AppCommon
{    
    public class Utility
    {      
        public string IsNumber(string str)
        {
            string Str = str;
            double Num;
            bool isNum = double.TryParse(Str, out Num);

            if (isNum)
                return "Yes";
            else
                return "No";
        }    
    }
}

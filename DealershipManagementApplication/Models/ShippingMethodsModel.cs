using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.Models
{
    public class ShippingMethodsModel : BaseModel
    {
        private string _ShippingMethodName;
        public string ShippingMethodName
        {
            get { return _ShippingMethodName; }
            set { _ShippingMethodName = value; }
        }
    }
}

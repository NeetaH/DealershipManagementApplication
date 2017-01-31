using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.Models
{
    public class PaymentMethodModel : BaseModel
    {
        private string _PaymentMethodName;
        public string PaymentMethodName
        {
            get { return _PaymentMethodName; }
            set { _PaymentMethodName = value; }
        }
    }
}

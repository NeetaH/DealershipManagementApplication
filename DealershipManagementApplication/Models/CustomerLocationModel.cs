using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.Models
{
    public class CustomerLocationModel : LocationModel
    {
        private CustomerModel _Customer;
        public CustomerModel Customer
        {
            get { return _Customer; }
            set { _Customer = value; }
        }
    }
}

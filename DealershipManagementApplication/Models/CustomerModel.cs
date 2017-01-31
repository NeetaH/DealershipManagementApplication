using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.Models
{
    public class CustomerModel : BaseModel
    {
        private string _CustomerName;
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        List<CustomerLocationModel> _CustomerLocations;
        public List<CustomerLocationModel> CustomerLocations
        {
            get
            {
                if (_CustomerLocations == null)
                    _CustomerLocations = new List<CustomerLocationModel>();
                return _CustomerLocations;
            }
        }
    }
}

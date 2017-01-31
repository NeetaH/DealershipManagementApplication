using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.Models
{
    public class OwnerModel : BaseModel
    {
        private string _OwnerName;
        public string OwnerName
        {
            get { return _OwnerName; }
            set { _OwnerName = value; }
        }
    }
}

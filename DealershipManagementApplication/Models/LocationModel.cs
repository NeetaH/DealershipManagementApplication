using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.Models
{
    public class LocationModel : BaseModel
    {
        private string _LocationName;
        public string LocationName
        {
            get { return _LocationName; }
            set { _LocationName = value; }
        }
    }
}

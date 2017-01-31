using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.Models
{
    public class SalesTypeModel : BaseModel
    {
        private string _SalesTypeName;
        public string SalesTypeName
        {
            get { return _SalesTypeName; }
            set { _SalesTypeName = value; }
        }
    }
}

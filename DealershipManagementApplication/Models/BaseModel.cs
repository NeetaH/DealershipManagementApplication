using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.Models
{
    public class BaseModel
    {
        private int _Oid;
        public int Oid
        {
            get { return _Oid; }
            set { _Oid = value; }
        }
    }
}

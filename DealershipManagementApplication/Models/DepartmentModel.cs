using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.Models
{
    public class DepartmentModel : BaseModel
    {
        private string _DepartmentName;
        public string DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }

        public List<DepartmentModel> GetSchedules()
        {
            return new List<DepartmentModel>();
        }
    }
}

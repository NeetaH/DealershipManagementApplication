using DealershipManagementApplication.Data;
using DealershipManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.ViewModels
{
    public class SalesFrontCounterViewModel
    {
        public SalesFrontCounterViewModel()
        {
            DepartmentDescList = new List<DepartmentModel>();
            DepartmentDescList.AddRange(DataFactory.Departments);
            LocationList = new List<LocationModel>();
            LocationList.AddRange(DataFactory.Locations);
            if (Model == null)
                Model = new SalesFrontCounterModel();
        }

        public SalesFrontCounterModel Model { get; set; }

        public List<DepartmentModel> DepartmentDescList { get; set; }
        public List<LocationModel> LocationList { get; set; }
    }
}

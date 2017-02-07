using DealershipManagementApplication.Data;
using DealershipManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.ViewModels
{
    public class SalesFrontCounterViewModel : BaseViewModel
    {
        public SalesFrontCounterViewModel()
        {

        }

        public List<DepartmentModel> DepartmentDescList { get; set; }
        public List<LocationModel> LocationList { get; set; }

        public override void LoadCommonCollection()
        {
            base.LoadCommonCollection();
            CommonCollection.Add("Department", GetListData(DataFactory.Departments));
            CommonCollection.Add("Location", GetListData(DataFactory.Locations));
        }
        
        public override void Initialize()
        {
            base.Initialize();
            DepartmentDescList = GetData<DepartmentModel>("Department");
            LocationList = GetData<LocationModel>("Location");
        }

        protected override void InitiateDefaultState()
        {
            Model = new SalesFrontCounterModel();
            base.InitiateDefaultState();
        }

        protected override void InitiateSelectedState()
        {
            base.InitiateSelectedState();

            int primaryKey = GetPrimaryKey();
            if (primaryKey != 0)
            {
                Model = DataFactory.SalesFrontCounters.FirstOrDefault(t => t.Oid == primaryKey);
                if (Model == null)
                {
                    //Raise Msg selected record doesnot exists
                }
            }
        }
    }
}

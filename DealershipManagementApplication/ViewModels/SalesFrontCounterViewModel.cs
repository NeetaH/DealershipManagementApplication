using DealershipManagementApplication.CommonClass;
using DealershipManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace DealershipManagementApplication.ViewModels
{ 
    public class SalesFrontCounterViewModel :BaseViewModel
    {
        #region "Properties"
        private SalesFrontCounterModel _objModel;
        public SalesFrontCounterModel ObjModel
        {
            get { return _objModel; }
            set
            {
                _objModel = value;
                OnPropertyChanged("ObjModel");
            }
        }

        public ObservableCollection<SalesFrontCounterModel> SalesFrontCounterDetails { get; set; }
        Department getDepartmentID = new Department();
        CompanyLocation getCompLocation = new CompanyLocation();  
      
        public List<Department> DepartmentIDList{get;set;}
        public List<Department> DepartmentDescList { get; set; }
        public List<CompanyLocation> CompLocationList { get; set; }

        private string _SelectDeptID;
        public string SelectDeptID
        {
            get
            {
                return _SelectDeptID;
            }
            set
            {
                if (_SelectDeptID != value)
                {
                    _SelectDeptID = value;
                    OnPropertyChanged("SelectDeptID");
                }
            }
        }

        private string _SelectDeptDescID;
        public string SelectDeptDescID
        {
            get
            {
                return _SelectDeptDescID;
            }
            set
            {
                if (_SelectDeptDescID != value)
                {
                    _SelectDeptDescID = value;
                    OnPropertyChanged("SelectDeptDescID");
                }
            }
        }

        public List<Department> DepartmentIDListVar { get; set; }
        public List<CompanyLocation> CompLocationListVar { get; set; }


        #endregion


        #region "CommandProperties"        
        public ICommand SearchCommand { get; set; }
        #endregion

        #region "Constructor"
        public SalesFrontCounterViewModel()
        {
               // Initialize context in the default state
                ContextClass context = new ContextClass(DefaultState.Instance);
                context.Request(); // Handle the default state              
                SearchCommand = new DelegateCommand(ExecuteSearchClick);                            
        }

        #endregion
        private void ExecuteSearchClick()
        {
            ContextClass context = new ContextClass(SelectState.Instance); // Change the default to the select state                        
            context.Request(); // Handle the select state  
            GetSalesFrontCounter();           
        }

        private void GetSalesFrontCounter()
        {
            var objModel = new SalesFrontCounterModel();

            #region "HeaderDetails"
            objModel.HeaderDetails.SalesFrontCntNo = "565565";
            objModel.HeaderDetails.DocumentStatus = "Posted";
            objModel.HeaderDetails.JournalEntryNo = "565565";
            objModel.HeaderDetails.PostedBy = 101439;
            objModel.HeaderDetails.EstimationNo = "565565";
            objModel.HeaderDetails.CreatedBy = 101439;
            objModel.HeaderDetails.ShipToCustNo = "101439";
            objModel.HeaderDetails.BillToCustNo = "101439";  
                        
            #endregion

            #region "PaymentInformation"         
          
            CompLocationListVar = getCompLocation.GetCompanyLocationList();
            // PaymentMethodListVar = getPaymentMethod.getPaymentMethod();
            //ShippingMenthodListVar = getShippingMethod.getShippingMethod();
            //LostSalesReasonList = getgLostSalesReason.GetLostSalesReasonList();

           DepartmentIDListVar = getDepartmentID.getDepartmentNO();                       

            BindComboList();
            if (DepartmentDescList.Count == 1)
                SelectDeptDescID = DepartmentDescList.Find(X => X.Active.ToUpper() == "YES").DepartmentID.ToString();

            if (DepartmentIDList.Count == 1)
               SelectDeptID = DepartmentIDList.Find(X => X.Active.ToUpper() == "YES").DepartmentID.ToString();

            objModel.PaymentInformation.SellingLocation = "HFI";
            objModel.PaymentInformation.SalesTypeID = 3457465;
            objModel.PaymentInformation.StockID = 3457465;
            objModel.PaymentInformation.Owner = 3457465;
            objModel.PaymentInformation.ShipTo = 3457465;

            objModel.PaymentInformation.DateOpened = DateTime.Now.Date;
            objModel.PaymentInformation.DateClosed = DateTime.Now.Date;
            objModel.PaymentInformation.PostingDate = DateTime.Now.Date;
            objModel.PaymentInformation.EstimatedExpirationDate = DateTime.Now.Date;

            objModel.PaymentInformation.ShipingMethod = 3457465;

            #endregion

            #region "BillingInformation"
            objModel.CustomerPay.UseOutOfStateTax = true;
            objModel.CustomerPay.CustomerPayBeforeTax = 100;
            objModel.CustomerPay.SalesTax = 100;
            objModel.CustomerPay.BatteryTax = 100;
            objModel.CustomerPay.CustomerPayAfterTax = 100;
            objModel.CustomerPay.Deposits = 100;
            objModel.CustomerPay.Payments = 100;
            objModel.CustomerPay.AmountDue = 100;
            objModel.CustomerPay.PaymentAmount = 100;
            objModel.CustomerPay.PaymentMethod = 100;
            objModel.CustomerPay.CreditLimit = 100;
            objModel.CustomerPay.PostedBalance = 100;

            objModel.CustomerPay.PendingTransactions = 100;
            objModel.CustomerPay.AvailableCredit = 100;
            objModel.CustomerPay.PurchaseOrder = "100";
            objModel.CustomerPay.AuthorizationCode = "100";

            objModel.CustomerPay.EstimatedSales = 100;
            objModel.CustomerPay.AmountSubmitted = 100;

            objModel.InternalPay.NetReceivingAmount = 100;
                        
            #endregion
                                    
            ObjModel = objModel;

        }

        public void BindComboList(string type = "")
        {            
             if (!string.IsNullOrEmpty(type))
            {
                //var SalesType = SalesTypeListVar.FindAll(X => (X.Active.ToUpper() == "YES" || X.Active.ToUpper() == "TRUE" || X.Active.ToUpper() == "1") && X.isMapping == "1");
                //SalesTypeList = SalesType; //SalesTypeListVar;// 
                //OnPropertyChanged("SalesTypeList");            
            }
            else
            {
                var DepartmentID =DepartmentIDListVar.FindAll(X => X.Active.ToUpper() == "YES" || X.Active.ToUpper() == "TRUE" || X.Active.ToUpper() == "1");
                DepartmentIDList = DepartmentID;
                OnPropertyChanged("DepartmentIDList");

                var DepartmentDesc = DepartmentIDListVar.FindAll(X => X.Active.ToUpper() == "YES" || X.Active.ToUpper() == "TRUE" || X.Active.ToUpper() == "1");
                DepartmentDescList = DepartmentDesc;
                OnPropertyChanged("DepartmentDescList");

                //var PaymentMethod = PaymentMethodListVar.FindAll(X => (X.Active.ToUpper() == "YES" || X.Active.ToUpper() == "TRUE" || X.Active.ToUpper() == "1") && X.AppliesToPOS == "" && X.IsPartSales == "YES");
                //PaymentMethodList = PaymentMethod;
                //OnPropertyChanged("PaymentMethodList");

                var LocationMethod = CompLocationListVar.FindAll(X => X.Active.ToUpper() == "YES" || X.Active.ToUpper() == "TRUE" || X.Active.ToUpper() == "1");
                CompLocationList = LocationMethod;
                OnPropertyChanged("CompLocationList");

                //var ShippingMethodType = ShippingMenthodListVar.FindAll(X => X.Active.ToUpper() == "YES" || X.Active.ToUpper() == "TRUE" || X.Active.ToUpper() == "1");
                //ShippingMenthodList = ShippingMethodType;
                //OnPropertyChanged("ShippingMenthodList");
            }
        }


    }
}

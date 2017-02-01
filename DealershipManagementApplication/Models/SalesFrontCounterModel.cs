using DealershipManagementApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DMS.AppCommon;
using System.Data;
using System.Reflection.Emit;

namespace DealershipManagementApplication.Models
{   
    public class SalesFrontCounterModel : BaseViewModel
    {
        private SalesFrontPaymentInformation _PaymentInformation;
        public SalesFrontPaymentInformation PaymentInformation
        {
            get { return _PaymentInformation; }
            set { _PaymentInformation = value; }
        }

        private InternalPay _InternalPay;
        public InternalPay InternalPay
        {
            get { return _InternalPay; }
            set { _InternalPay = value; }
        }

        private CustomerPay _CustomerPay;
        public CustomerPay CustomerPay
        {
            get { return _CustomerPay; }
            set { _CustomerPay = value; }
        }

        private HeaderDetails _headerDetails;
        public HeaderDetails HeaderDetails
        {
            get { return _headerDetails; }
            set { _headerDetails = value; }
        }
    
        public SalesFrontCounterModel()
        {
            PaymentInformation = new SalesFrontPaymentInformation();
            HeaderDetails = new HeaderDetails();
            InternalPay = new InternalPay();
            CustomerPay = new CustomerPay();
        }           
        
    }



    #region "Customer-InternalBillingInformation"

    public class InternalPay
    {
        private decimal _NetReceivingAmount;
        public decimal NetReceivingAmount
        {
            get { return _NetReceivingAmount; }
            set { _NetReceivingAmount = value; }
        }
    }

    public class CustomerPay
    {
        private bool _UseOutOfStateTax;
        public bool UseOutOfStateTax
        {
            get { return _UseOutOfStateTax; }
            set { _UseOutOfStateTax = value; }
        }

        private decimal _CustomerPayBeforeTax;
        public decimal CustomerPayBeforeTax
        {
            get { return _CustomerPayBeforeTax; }
            set { _CustomerPayBeforeTax = value; }
        }

        private decimal _SalesTax;
        public decimal SalesTax
        {
            get { return _SalesTax; }
            set { _SalesTax = value; }
        }

        private decimal _BatteryTax;
        public decimal BatteryTax
        {
            get { return _BatteryTax; }
            set { _BatteryTax = value; }
        }

        private decimal _CustomerPayAfterTax;
        public decimal CustomerPayAfterTax
        {
            get { return _CustomerPayAfterTax; }
            set { _CustomerPayAfterTax = value; }
        }

        private decimal _Deposits;
        public decimal Deposits
        {
            get { return _Deposits; }
            set { _Deposits = value; }
        }

        private decimal _Payments;
        public decimal Payments
        {
            get { return _Payments; }
            set { _Payments = value; }
        }

        private decimal _AmountDue;
        public decimal AmountDue
        {
            get { return _AmountDue; }
            set { _AmountDue = value; }
        }

        private decimal _PaymentAmount;
        public decimal PaymentAmount
        {
            get { return _PaymentAmount; }
            set { _PaymentAmount = value; }
        }

        private decimal _PaymentMethod;
        public decimal PaymentMethod
        {
            get { return _PaymentMethod; }
            set { _PaymentMethod = value; }
        }

        private decimal _CreditLimit;
        public decimal CreditLimit
        {
            get { return _CreditLimit; }
            set { _CreditLimit = value; }
        }

        private decimal _PostedBalance;
        public decimal PostedBalance
        {
            get { return _PostedBalance; }
            set { _PostedBalance = value; }
        }

        private decimal _PendingTransactions;
        public decimal PendingTransactions
        {
            get { return _PendingTransactions; }
            set { _PendingTransactions = value; }
        }


        private decimal _AvailableCredit;
        public decimal AvailableCredit
        {
            get { return _AvailableCredit; }
            set { _AvailableCredit = value; }
        }

        private string _PurchaseOrder;
        public string PurchaseOrder
        {
            get { return _PurchaseOrder; }
            set { _PurchaseOrder = value; }
        }

        private string _AuthorizationCode;
        public string AuthorizationCode
        {
            get { return _AuthorizationCode; }
            set { _AuthorizationCode = value; }
        }

        private decimal _EstimatedSales;
        public decimal EstimatedSales
        {
            get { return _EstimatedSales; }
            set { _EstimatedSales = value; }
        }

        private decimal _AmountSubmitted;
        public decimal AmountSubmitted
        {
            get { return _AmountSubmitted; }
            set { _AmountSubmitted = value; }
        }
    }

    #endregion

    #region Header Fields
    public class HeaderDetails :BaseViewModel
    {
        private string _SalesFrontCntNo;
        public string SalesFrontCntNo
        {
            get { return _SalesFrontCntNo; }
            set { _SalesFrontCntNo = value; }
        }

        private string _DocumentStatus;
        public string DocumentStatus
        {
            get { return _DocumentStatus; }
            set { _DocumentStatus = value; }
        }

        private string _EstimationNo;
        public string EstimationNo
        {
            get { return _EstimationNo; }
            set { _EstimationNo = value; }
        }

        private string _JournalEntryNo;
        public string JournalEntryNo
        {
            get { return _JournalEntryNo; }
            set { _JournalEntryNo = value; }
        }

        private int _CreatedBy;
        public int CreatedBy
        {
            get { return _CreatedBy; }
            set
            {
                _CreatedBy = value;
            }
        }

        private int _PostedBy;
        public int PostedBy
        {
            get { return _PostedBy; }
            set { _PostedBy = value; }
        }

        private string _OwnerToCustNo;
        public string OwnerToCustNo
        {
            get
            {
                return _OwnerToCustNo;
            }
            set
            {
                if (_OwnerToCustNo != value)
                {
                    _OwnerToCustNo = value;
                    OnPropertyChanged("OwnerToCustNo");
                }
            }
        }

        private string _ShipToCustNo;
        public string ShipToCustNo
        {
            get
            {
                return _ShipToCustNo;
            }
            set
            {
                if (_ShipToCustNo != value)
                {
                    _ShipToCustNo = value;
                    OnPropertyChanged("ShipToCustNo");
                }
            }
        }

        private string _BillToCustNo;
        public string BillToCustNo
        {
            get
            {
                return _BillToCustNo;
            }
            set
            {
                if (_BillToCustNo != value)
                {
                    _BillToCustNo = value;
                    OnPropertyChanged("BillToCustNo");                    
                }
            }
        }
    }
    #endregion

    #region "PaymentInformation"
    public class SalesFrontPaymentInformation :BaseViewModel
    {
                        
        private string _SellingLocation;
        public string SellingLocation
        {
            get { return _SellingLocation; }
            set { _SellingLocation = value; }
        }

        private int _SalesTypeID;
        public int SalesTypeID
        {
            get { return _SalesTypeID; }
            set { _SalesTypeID = value; }
        }

     
        private int _StockID;
        public int StockID
        {
            get { return _StockID; }
            set { _StockID = value; }
        }

        private int _Owner;
        public int Owner
        {
            get { return _Owner; }
            set { _Owner = value; }
        }

        private int _ShipTo;
        public int ShipTo
        {
            get { return _ShipTo; }
            set { _ShipTo = value; }
        }

        private DateTime _DateOpened;
        public DateTime DateOpened
        {
            get { return _DateOpened; }
            set { _DateOpened = value; }
        }

        private DateTime _DateClosed;
        public DateTime DateClosed
        {
            get { return _DateClosed; }
            set { _DateClosed = value; }
        }

        private DateTime _PostingDate;
        public DateTime PostingDate
        {
            get { return _PostingDate; }
            set { _PostingDate = value; }
        }

        private DateTime _EstimatedExpirationDate;
        public DateTime EstimatedExpirationDate
        {
            get { return _EstimatedExpirationDate; }
            set { _EstimatedExpirationDate = value; }
        }

        private int _ShipingMethod;
        public int ShipingMethod
        {
            get { return _ShipingMethod; }
            set { _ShipingMethod = value; }
        }
    }
  
    #endregion

    public class Department
    {
        public Int64 DepartmentID { get; set; }
        public string DepartmentNo { get; set; }
        public int DepartmentTypeID { get; set; }
        public string Active { get; set; }
        public string DepartmentName { get; set; }

        public List<Department> getDepartmentNO()
            {                
                try
                {
                    
                    List<Department> returnDepartmentNO = new List<Department>();
                  
                            returnDepartmentNO.Add(new Department() { 
                                                            DepartmentTypeID = 1, 
                                                            DepartmentID = 101101,
                                                            DepartmentName = "PARTS",
                                                            DepartmentNo = "0101", Active = "Yes" });                                    
                    return returnDepartmentNO ;                
                }
                catch (Exception ex)
                {                    
                    return null;
                }
            }

       //public List<Department> getDepartmentName()
       //     {             
       //         try
       //         {
       //             List<Department> returnDescription = new List<Department>();                   
       //              returnDescription.Add(new Department() {
       //                  DepartmentTypeID =1, 
       //                  DepartmentID = 101101,
       //                  DepartmentName = "PARTS", 
       //                  Active = "Yes" });
                                 
       //             return returnDescription;//.Where(x => x.Active == "YES" || x.DepartmentID == DepartmentID).ToList(); 
       //         }
       //         catch (Exception ex)
       //         {                  
       //             return null;
       //         }
       //     }

     }

    public class CompanyLocation
    {
        public int LocationID { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string Active { get; set; }

        public List<CompanyLocation> GetCompanyLocationList(int LocationID = 0)
        {            
            try
            {                
                List<CompanyLocation> returnCompanyLocationList = new List<CompanyLocation>();               
                   returnCompanyLocationList.Add(new CompanyLocation() { 
                       LocationID = 1, 
                       LocationCode = "001", 
                       LocationName = "HFI-MainWarehouse",
                       Active = "Yes"});                

                return returnCompanyLocationList;              
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}


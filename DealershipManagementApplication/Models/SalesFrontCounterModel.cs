using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.Models
{
    public class SalesFrontCounterModel : INotifyPropertyChanged
    {
        public SalesFrontCounterModel()
        {
            PaymentInformation = new SalesFrontPaymentInformation();
        }

        public List<InternalPay> InternalPayDetails { get; set; }
        public List<CustomerPay> CustomerPayDetails { get; set; }
        public List<InternalPay> WarrantyPayDetails { get; set; }

        private SalesFrontPaymentInformation _PaymentInformation;
        public SalesFrontPaymentInformation PaymentInformation
        {
            get { return _PaymentInformation; }
            set { _PaymentInformation = value; }
        }

        #region INotifyPropertyChanged
        new public event PropertyChangedEventHandler PropertyChanged;

        new public void OnPropertyChanged(string propertyName)
        {
            try
            {
                var handler = PropertyChanged;
                if (handler != null)
                {
                    var e = new PropertyChangedEventArgs(propertyName);
                    handler(this, e);
                }
            }
            catch
            { }
        }
        #endregion
    }

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

    #region Header Fields
    public class HeaderDetails
    {
        private string _InvoiceNumber;
        public string InvoiceNumber
        {
            get { return _InvoiceNumber; }
            set { _InvoiceNumber = value; }
        }

        private string _Status;
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private string _Estimate;
        public string Estimate
        {
            get { return _Estimate; }
            set { _Estimate = value; }
        }

        private string _JournalEntry;
        public string JournalEntry
        {
            get { return _JournalEntry; }
            set { _JournalEntry = value; }
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
    }
  
    

    public class SalesFrontPaymentInformation
    {
        private int _DepartmentID;
        public int DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

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
}

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
        public List<InternalPay> InternalPayDetails { get; set; }
        public List<CustomerPay> CustomerPayDetails { get; set; }
        public List<InternalPay> WarrantyPayDetails { get; set; }


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
    
}

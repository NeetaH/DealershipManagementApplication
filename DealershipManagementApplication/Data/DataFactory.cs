using DealershipManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.Data
{
    public class DataFactory
    {
        public static void Register()
        {

        }

        public static List<PaymentMethodModel> PaymentMethods { get; set; }
        public static List<ShippingMethodsModel> ShippingMethods { get; set; }
        public static List<CustomerLocationModel> CustomerLocations { get; set; }
        public static List<CustomerModel> Customers { get; set; }
        public static List<OwnerModel> Owners { get; set; }
        public static List<StocksModel> Stocks { get; set; }
        public static List<SalesTypeModel> SellingTypes { get; set; }
        public static List<DepartmentModel> Departments { get; set; }
        public static List<LocationModel> Locations { get; set; }
        public static List<EmployeeModel> Employees { get; set; }
        public static List<SalesFrontCounterModel> SalesFrontCounters { get; set; }

        static DataFactory()
        {
            CreateData();
        }

        static void CreateData()
        {
            CreateDepartments(1);
            CreateSellingTypes(1);
            CreateStocks(1);
            CreateOwners(1);
            CreateCustomers(1);
            CreateShippingMethods(1);
            CreatePaymentMethods(1);
            CreateLocations(1);
            CreateEmployeeData(1);
            CreateSalesFrontCounterData();
        }

        #region Mock Code
        //T CreateRecord<T>() where T : BaseModel
        //{
        //    return new Moq.Mock<T>().Object;
        //}

        //static void TestMoq(int noOfRecords = 1000)
        //{
        //    ShippingMethods = new List<ShippingMethodsModel>();

        //    for (int i = 0; i <= noOfRecords; i++)
        //    {
        //        var mockShippingMethods = new Moq.Mock<ShippingMethodsModel>();
        //        mockShippingMethods.SetupProperty(t => t.ShippingMethodName, string.Concat("Shipping Methods ", i)).SetupProperty(t => t.Oid, i);
        //        ShippingMethods.Add(mockShippingMethods.Object);

        //    }
        //    mockShippingMethods.SetupGet(t => t.ShippingMethodName);

        //    //Create a mock object of a MailClient class which implements IMailClient
        //    var mockMailClient = new Moq.Mock<PaymentMethodModel>();

        //    //Mock the properties of MailClient
        //    mockMailClient
        //        .SetupProperty(client => client.Oid, 1).SetupProperty(client => client.PaymentMethodName, "1212");
        //    mockMailClient
        //        .SetupProperty(client => client.Oid, 2).SetupProperty(client => client.PaymentMethodName, "Ganesh");
        //    mockMailClient
        //        .SetupProperty(client => client.Oid, 2).SetupProperty(client => client.PaymentMethodName, "Rakesh");

        //    ////Configure dummy method so that it return true when it gets any string as parameters to the method
        //    //mockMailClient.Setup(client => client.SendMail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);

        //    //IMailer mailer = new DefaultMailer() { From = "from@mail.com", To = "to@mail.com", Subject = "Using Moq", Body = "Moq is awesome" };

        //    ////Use the mock object of MailClient instead of actual object
        //    //var result = mailer.SendMail(mockMailClient.Object);

        //    ////Verify that it return true
        //    //Assert.IsTrue(result);

        //    ////Verify that the MailClient's SendMail methods gets called exactly once when string is passed as parameters
        //    //mockMailClient.Verify(client => client.SendMail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);


        //}
        #endregion

        static void CreateDepartments(int noOfRecords = 1000)
        {
            noOfRecords = 300;
            Departments = new List<DepartmentModel>();

            int personIdIncrement = 1;
            Departments.AddRange(Enumerable.Range(0, noOfRecords).Select(o => new DepartmentModel()
            {
                Oid = personIdIncrement++,
                DepartmentName = MockData.Person.FullName()
            }).ToList());

            #region commented Code

            //Departments.AddRange(Enumerable.Range(0, noOfRecords).Select(o => new Mock<DepartmentModel>()
            //    .SetupProperty(t => t.Oid, 1)
            //    .SetupProperty(t => t.DepartmentName, MockData.Person.FullName()).Object).ToList());


            //for (int i = 0; i <= noOfRecords; i++)
            //{
            //    DepartmentModel department = new DepartmentModel();
            //    department.Oid = i;
            //    department.DepartmentName = string.Concat("Department ", i);
            //    Departments.Add(department);
            //}

            //Departments.AddRange(Enumerable.Range(0, noOfRecords).Select(o => new DepartmentModel
            //            {
            //                Oid = personIdIncrement++,
            //                DepartmentName = MockData.Person.FullName(),
            //            }).ToList());

            //Mock.Of<DepartmentModel>(Enumerable.Repeat(Mock.Of<DepartmentModel>(), numberOfElements).ToList());

            #endregion
        }

        static void CreateSellingTypes(int noOfRecords = 1000)
        {
            SellingTypes = new List<SalesTypeModel>();
            for (int i = 0; i <= noOfRecords; i++)
            {
                SalesTypeModel salesType = new SalesTypeModel();
                salesType.Oid = i;
                salesType.SalesTypeName = string.Concat("Sales Type  ", i);
                SellingTypes.Add(salesType);
            }
        }

        static void CreateStocks(int noOfRecords = 1000)
        {
            Stocks = new List<StocksModel>();
            for (int i = 0; i <= noOfRecords; i++)
            {
                StocksModel stock = new StocksModel();
                stock.Oid = i;
                stock.StockName = string.Concat("Stock ", i);
                Stocks.Add(stock);
            }
        }

        static void CreateOwners(int noOfRecords = 1000)
        {
            Owners = new List<OwnerModel>();
            for (int i = 0; i <= noOfRecords; i++)
            {
                OwnerModel owner = new OwnerModel();
                owner.Oid = i;
                owner.OwnerName = string.Concat("Owner ", i);
                Owners.Add(owner);
            }
        }

        static void CreateCustomers(int noOfRecords = 1000)
        {
            Customers = new List<CustomerModel>();
            CustomerLocations = new List<CustomerLocationModel>();
            for (int i = 0; i <= noOfRecords; i++)
            {
                CustomerModel customer = new CustomerModel();
                customer.Oid = i;
                customer.CustomerName = string.Concat("Customer ", i);
                customer.CustomerLocations.Add(CreateCustomersLocation(customer));
                Customers.Add(customer);
            }
        }

        static CustomerLocationModel CreateCustomersLocation(CustomerModel customer)
        {
            var customerLocation = new CustomerLocationModel() { Customer = customer, LocationName = customer.CustomerName, Oid = customer.Oid };
            CustomerLocations.Add(customerLocation);
            return customerLocation;
        }


        static void CreateShippingMethods(int noOfRecords = 1000)
        {
            ShippingMethods = new List<ShippingMethodsModel>();
            for (int i = 0; i <= noOfRecords; i++)
            {
                ShippingMethodsModel shippingMethod = new ShippingMethodsModel();
                shippingMethod.Oid = i;
                shippingMethod.ShippingMethodName = string.Concat("Shipping Methods ", i);
                ShippingMethods.Add(shippingMethod);
            }
        }

        static void CreatePaymentMethods(int noOfRecords = 1000)
        {
            PaymentMethods = new List<PaymentMethodModel>();
            for (int i = 0; i <= noOfRecords; i++)
            {
                PaymentMethodModel locationModel = new PaymentMethodModel();
                locationModel.Oid = i;
                locationModel.PaymentMethodName = string.Concat("Payment Methods ", i);
                PaymentMethods.Add(locationModel);
            }
        }
        static void CreateLocations(int noOfRecords = 1000)
        {
            Locations = new List<LocationModel>();
            for (int i = 0; i <= noOfRecords; i++)
            {
                LocationModel locationModel = new LocationModel();
                locationModel.Oid = i;
                locationModel.LocationName = string.Concat("Location ", i);
                Locations.Add(locationModel);
            }
        }

        static void CreateEmployeeData(int noOfRecords = 1000)
        {
            Employees = new List<EmployeeModel>();
            for (int i = 0; i <= noOfRecords; i++)
            {
                EmployeeModel employeeModel = new EmployeeModel();
                employeeModel.Oid = i;
                employeeModel.EmployeeName = string.Concat("Employee ", i);
                Employees.Add(employeeModel);
            }
        }

        static void CreateSalesFrontCounterData(int noOfRecords = 1000)
        {
            SalesFrontCounters = new List<SalesFrontCounterModel>();
            for (int i = 0; i <= noOfRecords; i++)
            {
                SalesFrontCounterModel salesFrontCounterModel = new SalesFrontCounterModel();
                salesFrontCounterModel.Oid = 1;

                #region HeaderDetails
                HeaderDetails headerDetails = new HeaderDetails();
                headerDetails.InvoiceNumber = string.Concat("Inv/", DateTime.Today.Date, "/", i);
                headerDetails.Status = "New";
                headerDetails.JournalEntry = string.Concat("JV/", DateTime.Today.Date, "/", i);
                headerDetails.CreatedBy = GetValue(Employees.Cast<BaseModel>().ToList());
                headerDetails.PostedBy = GetValue(Employees.Cast<BaseModel>().ToList()); ;

                salesFrontCounterModel.HeaderDetails = headerDetails;
                #endregion

                #region PaymentInformation
                SalesFrontPaymentInformation paymentInformation = new SalesFrontPaymentInformation();
                paymentInformation.DepartmentID = GetValue(Departments.Cast<BaseModel>().ToList());
                paymentInformation.SellingLocation = GetValue(Locations.Cast<BaseModel>().ToList());
                paymentInformation.SalesTypeID = GetValue(SellingTypes.Cast<BaseModel>().ToList());
                paymentInformation.StockID = GetValue(Stocks.Cast<BaseModel>().ToList());
                paymentInformation.Owner = GetValue(Owners.Cast<BaseModel>().ToList());
                paymentInformation.ShipTo = GetValue(CustomerLocations.Cast<BaseModel>().ToList());
                paymentInformation.DateOpened = DateTime.Now;
                paymentInformation.DateClosed = DateTime.Now.AddDays(2);

                paymentInformation.PostingDate = default(DateTime);
                paymentInformation.EstimatedExpirationDate = default(DateTime);

                paymentInformation.ShipingMethod = GetValue(ShippingMethods.Cast<BaseModel>().ToList());
                salesFrontCounterModel.PaymentInformation = paymentInformation;
                #endregion

                #region CustomerPay
                CustomerPay customerPay = new CustomerPay();
                customerPay.UseOutOfStateTax = true;
                customerPay.CustomerPayBeforeTax = GetCustomerPayBeforeTax(salesFrontCounterModel);
                customerPay.SalesTax = GetSalesTax(salesFrontCounterModel);
                customerPay.BatteryTax = GetBatteryTax(salesFrontCounterModel);
                customerPay.CustomerPayAfterTax = customerPay.CustomerPayBeforeTax + customerPay.SalesTax + customerPay.BatteryTax;
                customerPay.Deposits = 0;
                customerPay.Payments = 0;
                customerPay.AmountDue = customerPay.CustomerPayAfterTax - (customerPay.Deposits + customerPay.Payments);

                customerPay.PaymentAmount = 0;
                customerPay.PaymentMethod = GetValue(PaymentMethods.Cast<BaseModel>().ToList());
                customerPay.CreditLimit = 0;
                customerPay.PostedBalance = 0;
                customerPay.PendingTransactions = 0;
                customerPay.AvailableCredit = 0;
                customerPay.PurchaseOrder = string.Empty;
                customerPay.AuthorizationCode = string.Empty;
                customerPay.EstimatedSales = 0;
                customerPay.AmountSubmitted = 0;

                salesFrontCounterModel.CustomerPayDetails = customerPay;
                #endregion

                SalesFrontCounters.Add(salesFrontCounterModel);
            }
        }

        private static int GetValue(List<BaseModel> List)
        {
            if (Employees.Count > 0)
                return Employees.FirstOrDefault().Oid;
            return 0;
        }

        //TODO : Create Data
        private static decimal GetCustomerPayBeforeTax(SalesFrontCounterModel salesFrontCounter)
        {
            if (Employees.Count > 0)
                return 0;
            return 0;
        }

        //TODO : Create Data
        private static decimal GetSalesTax(SalesFrontCounterModel salesFrontCounter)
        {
            if (Employees.Count > 0)
                return 0;
            return 0;
        }

        //TODO : Create Data
        private static decimal GetBatteryTax(SalesFrontCounterModel salesFrontCounter)
        {
            if (Employees.Count > 0)
                return 0;
            return 0;
        }
    }
}

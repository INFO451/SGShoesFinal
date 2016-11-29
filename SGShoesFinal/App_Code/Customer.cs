using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGShoesFinal.App_Code
{
    public class Customer
    {
        private int _id = 0;
        private string _FirstName = string.Empty;
        private string _LastName = string.Empty;
        private string _CustomerType = string.Empty;
        private string _ShippingAddress = string.Empty;
        private string _BillingAddress = string.Empty;
        private string _Phone = string.Empty;
        private string _Email = string.Empty;
        private string _Username = string.Empty;
        private string _Website = string.Empty;
        private bool _CreditApproval = false;
        private string _StatusFlag = string.Empty;


        public int CustId
        {
            get { return _id; }
            set { _id = value; }
        }

        public string CustFirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        /// <summary>
        /// First Name
        /// </summary>
        public string CustLastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        /// <summary>
        /// Last Name
        /// </summary>
        public string CustType
        {
            get { return _CustomerType; }
            set { _CustomerType = value; }
        }
        /// <summary>
        /// Customer Type
        /// </summary>

        public string CustShippingAddress
        {
            get { return _ShippingAddress; }
            set { _ShippingAddress = value; }
        }
        /// <summary>
        /// Customer Shipping Address
        /// </summary>

        public string CustBillingAddress
        {
            get { return _BillingAddress; }
            set { _BillingAddress = value; }
        }
        /// <summary>
        /// Customer Billing Address
        /// </summary>

        public string CustPhone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        /// <summary>
        /// Customer Phone
        /// </summary>

        public string CustEmail
        {
            get { return _Email; }
            set { _Email = value; }
        }
        /// <summary>
        /// Customer Email
        /// </summary>

        public string CustUsername
        {
            get { return _Username; }
            set { _Username = value; }
        }
        /// <summary>
        /// Customer Username
        /// </summary>

        public string CustWebsite
        {
            get { return _Website; }
            set { _Website = value; }
        }
        /// <summary>
        /// Customer Website
        /// </summary>

        public bool CustCreditApproval
        {
            get { return _CreditApproval; }
            set { _CreditApproval = value; }
        }
        /// <summary>
        /// Customer Credit Approval
        /// </summary>

        public string CustStatusFlag
        {
            get { return _StatusFlag; }
            set { _StatusFlag = value; }
        }
        /// <summary>
        /// Customer Status Flag
        /// </summary>
       

        /*     private void Save()
             {
                 if (String.IsNullOrEmpty(_size))
                     throw new ArgumentException("First Name not supplied", "sSize");
                 if (_size.Length > 50)
                     throw new ArgumentException("First Name must be less than 50 characters", "sSize");
                 if (String.IsNullOrEmpty(_descripShort))
                     throw new ArgumentException("Last Name not supplied", "shortDes");
                 if (_descripShort.Length > 50)
                     throw new ArgumentException("Last Name must be less than 50 characters", "shortDes");
                 if (string.IsNullOrEmpty(_descripLong))
                     throw new ArgumentException("LongDescrip not supplied", "longDes");
                 if (_descripLong.Length > 2)
                     throw new ArgumentException("LongDescrip should only be one char", "longDes");
                 if (String.IsNullOrEmpty(_unitPrice))
                     throw new ArgumentException("UnitPrice not supplied", "unitPrice");
                 if (String.IsNullOrEmpty(_keywords))
                     throw new ArgumentException("Keywords not supplied", "Keywords");
                 if (String.IsNullOrEmpty(_imageLocS))
                     throw new ArgumentException("ImageLocSmall not supplied", "ImageLocSmall");
                 /*  if (DateTime.(_dob))
                       throw new ArgumentException("Date of Birth not supplied", "dob");
                  /* if (decimal.IsNaN(_rate))
                       throw new ArgumentException("Rate is invalid", "rate"); 



                 DBUtils dataAccessLayer = new DBUtils();
                 if (_prodId > 0)
                     dataAccessLayer.DBObjectUpdate(this);
                 else
                     dataAccessLayer.DBObjectInsert(this);
             } */
        /// <summary>
        /// Initializes DBObject
        /// </summary>
        /// <param name="fname">First Name</param>
        /// <param name="sQuant">Manfac Initial</param>
        /// <param name="lname">Product Description</param>
        /// <param name="longDes">DBObject LongDescrip</param>
        /// <param name="unitWeight">DBObject Street Adress</param>
        /// <param name="unitPrice">DBObject UnitPrice</param>
        /// <param name="Keywords">DBObject Keywords</param>
        /// <param name="smallLoc">DBObject ImageLocSmall Code</param>
        /// <param name="hphone">DBObject Home Phone</param>
        /// <param name="cell">DBObject Cell Phone</param>
        /// <param name="email">DBObject Email</param>
        /// <param name="dob">DBObject Date of Birth</param>
        /// <param name="active">Active Account</param>
        /// <param name="rate">Hourly Rate</param>
        public Customer(string CustFirstName, string CustLastName, string CustType, string CustShippingAddress, string CustBillingAddress, string CustPhone, string CustEmail, string CustUsername, string CustWebsite, bool CustCreditApproval, string CustStatusFlag)
            : this(0, CustFirstName, CustLastName, CustType, CustShippingAddress, CustBillingAddress, CustPhone, CustEmail, CustUsername, CustWebsite, CustCreditApproval, CustStatusFlag) { }

        /// <summary>
        /// Initializes DBObject
        /// </summary>
        /// <param name="id">DBObject Id</param>
        /// <param name="fname">First Name</param>
        /// <param name="sQuant">Manfac Initial</param>
        /// <param name="lname">Product Description</param>
        /// <param name="longDes">DBObject LongDescrip</param>
        /// <param name="unitWeight">DBObject Street Adress</param>
        /// <param name="unitPrice">DBObject UnitPrice</param>
        /// <param name="Keywords">DBObject Keywords</param>
        /// <param name="smallLoc">DBObject ImageLocSmall Code</param>
        /// <param name="hphone">DBObject Home Phone</param>
        /// <param name="cell">DBObject Cell Phone</param>
        /// <param name="email">DBObject Email</param>
        /// <param name="dob">DBObject Date of Birth</param>
        /// <param name="active">Active Account</param>
        /// <param name="rate">Hourly Rate</param>
        public Customer(int CustId,string CustFirstName, string CustLastName, string CustType, string CustShippingAddress, string CustBillingAddress, string CustPhone, string CustEmail, string CustUsername, string CustWebsite, bool CustCreditApproval, string CustStatusFlag)
        {
            _id = CustId;
            _FirstName = CustFirstName;
            _LastName = CustLastName;
            _CustomerType = CustType;
            _ShippingAddress = CustShippingAddress;
            _BillingAddress = CustBillingAddress;
            _Phone = CustPhone;
            _Email = CustEmail;
            _Username = CustUsername;
            _Website = CustWebsite;
            _CreditApproval = CustCreditApproval;
            _StatusFlag = CustStatusFlag;
        }
        public static List<Customer> getAllCustomers()
        {
            DBUtils dataAccessLayer = new DBUtils();
            return dataAccessLayer.CustomerSelectAll();
        }


        public static void insertCustomer(Customer newCustomer)
        {
            DBUtils dataAccessLayer = new DBUtils();
            dataAccessLayer.CustomerInsert(newCustomer);
        }

        /// <summary>
        /// Deletes an existing Customer
        /// </summary>
        /// <param name="id">Customer Id</param>
        public static void deleteCustomer(Customer objectToDelete)
        {
            int id = objectToDelete.CustId;
            if (id < 1)
                throw new ArgumentException("Product Id must be greater than 0", "id");

            DBUtils dataAccessLayer = new DBUtils();
            dataAccessLayer.CustomerDelete(id);
        }


        public static void updateCustomer(Customer CustomerToUpdate)
        {
            if (CustomerToUpdate.CustId < 1)
                throw new ArgumentException("Customer Id must be greater than 0", "id");

            DBUtils dataAccessLayer = new DBUtils();
            dataAccessLayer.CustomerUpdate(CustomerToUpdate);
        }


    }
}

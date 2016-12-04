using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGShoesFinal.App_Code;

namespace SGShoesFinal.App_Code
{
    public class Order
    {

        private int _id = 0;
        private int _CustId = 0;
        private int _ProdId = 0;
        private int _Quantity = 0;
        private DateTime? _SaleDate = null;
        private string _OrderStatus = string.Empty;



        public int OrderId
        {
            get { return _id; }
            set { _id = value; }
        }

        public int CustId
        {
            get { return _CustId; }
            set { _CustId = value; }
        }
        /// <summary>
        /// Customer ID
        /// </summary>
        public int ProdId
        {
            get { return _ProdId; }
            set { _ProdId = value; }
        }
        /// <summary>
        /// Product ID
        /// </summary>
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        /// <summary>
        /// Order Quantity
        /// </summary>

        public DateTime? SaleDate
        {
            get { return _SaleDate; }
            set { _SaleDate = value; }
        }
        /// <summary>
        /// Order Sale Date
        /// </summary>

        public string OrderStatus
        {
            get { return _OrderStatus; }
            set { _OrderStatus = value; }
        }
        /// <summary>
        /// Order Status
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
        public Order(int CustId, int ProdId, int Quantity, DateTime? SaleDate, string OrderStatus)
            : this(0, CustId, ProdId, Quantity, SaleDate, OrderStatus) { }

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
        public Order(int id, int CustId, int ProdId, int Quantity, DateTime? SaleDate, string OrderStatus)
        {
            _id = OrderId;
            _CustId = CustId;
            _ProdId = ProdId;
            _Quantity = Quantity;
            _SaleDate = SaleDate;
            _OrderStatus = OrderStatus;
     
        }
        public static List<Order> getAllOrders()
        {
            DBUtils dataAccessLayer = new DBUtils();
            return dataAccessLayer.OrderSelectAll();
        }


        public static void insertOrder(Order newOrder)
        {
            DBUtils dataAccessLayer = new DBUtils();
            dataAccessLayer.OrderInsert(newOrder);
        }

        /// <summary>
        /// Deletes an existing Customer
        /// </summary>
        /// <param name="id">Customer Id</param>
        public static void deleteOrder(Order objectToDelete)
        {
            int id = objectToDelete.OrderId;
            if (id < 1)
                throw new ArgumentException("Product Id must be greater than 0", "id");

            DBUtils dataAccessLayer = new DBUtils();
            dataAccessLayer.OrderDelete(objectToDelete);
        }


        public static void updateOrder(Order OrderToUpdate)
        {
            if (OrderToUpdate.OrderId < 1)
                throw new ArgumentException("Customer Id must be greater than 0", "id");

            DBUtils dataAccessLayer = new DBUtils();
            dataAccessLayer.OrderUpdate(OrderToUpdate);
        }


    }
}
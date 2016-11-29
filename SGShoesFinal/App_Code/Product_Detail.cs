using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGShoesFinal.App_Code
{
    public class Product_Detail
    {
        private int _id = 0;
        private int _prodId = 0;
        private int _size = 0;
        private int _quantity = 0;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int CatId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }
        /// <summary>
        /// First Name
        /// </summary>
        public int ProdName
        {
            get { return _size; }
            set { _size = value; }
        }
        /// <summary>
        /// Manfac Initial
        /// </summary>
        public int Manfac
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        /// <summary>
        /// Last Name
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
        public Product_Detail(int prodId, int sSize, int sQuant)
            : this(0, prodId, sSize, sQuant) { }

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
        public Product_Detail(int id, int prodId, int sSize, int sQuant)
        {
            _id = id;
            _prodId = prodId;
            _size = sSize;
            _quantity = sQuant;
        }
    }
}
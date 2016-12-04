using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGShoesFinal.App_Code
{
    public class Product
    {
        private int _id = 0;
        private int _catId = 0;
        private string _productN = String.Empty;
        private string _manufacturer = String.Empty;
        private string _descripShort = String.Empty;
        private string _descripLong = String.Empty;

        private double _unitWeight = 0;
        private decimal _unitPrice = 0;
        private string _keywords = String.Empty;
        private string _imageLocS = String.Empty;
        private string _imageLocL = String.Empty;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int CatId
        {
            get { return _catId; }
            set { _catId = value; }
        }
        /// <summary>
        /// First Name
        /// </summary>
        public string ProdName
        {
            get { return _productN; }
            set { _productN = value; }
        }
        /// <summary>
        /// Manfac Initial
        /// </summary>
        public string Manfac
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
        /// <summary>
        /// Last Name
        /// </summary>
        public string ShortDescrip
        {
            get { return _descripShort; }
            set { _descripShort = value; }
        }
        public string LongDescrip
        {
            get { return _descripLong; }
            set { _descripLong = value; }
        }
        public double UnitWeight
        {
            get { return _unitWeight; }
            set { _unitWeight = value; }
        }
        public decimal unitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
        public string Keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }
        public string ImageLocSmall
        {
            get { return _imageLocS; }
            set { _imageLocS = value; }
        }
        public string ImageLocLarge
        {
            get { return _imageLocL; }
            set { _imageLocL = value; }
        }


   /*     private void Save()
        {
            if (String.IsNullOrEmpty(_productN))
                throw new ArgumentException("First Name not supplied", "pName");
            if (_productN.Length > 50)
                throw new ArgumentException("First Name must be less than 50 characters", "pName");
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
            if (_catId > 0)
                dataAccessLayer.DBObjectUpdate(this);
            else
                dataAccessLayer.DBObjectInsert(this);
        } */
        /// <summary>
        /// Initializes DBObject
        /// </summary>
        /// <param name="fname">First Name</param>
        /// <param name="manufacture">Manfac Initial</param>
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
        public Product(int cid ,string pName, string manufacture, string shortDes, string longDes, double unitWeight, decimal unitPrice, string Keywords, string smallLoc, string LargeLoc)
            : this(0, cid, pName, manufacture, shortDes, longDes, unitWeight, unitPrice, Keywords, smallLoc, LargeLoc) { }

        /// <summary>
        /// Initializes DBObject
        /// </summary>
        /// <param name="id">DBObject Id</param>
        /// <param name="fname">First Name</param>
        /// <param name="manufacture">Manfac Initial</param>
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
        public Product(int id, int cid, string pName, string manufacture, string shortDes, string longDes, double unitWeight, decimal unitPrice, string Keywords, string smallLoc, string LargeLoc)
        {
            _id = id;
            _catId = cid;
            _productN = pName;
            _manufacturer = manufacture;
            _descripShort = shortDes;
            _descripLong = longDes;
            _unitWeight = unitWeight;
            _unitPrice = unitPrice;
            _keywords = Keywords;
            _imageLocS = smallLoc;
            _imageLocL = LargeLoc;
        }

        public static List<Product> getAllProducts()
        {
            DBUtils dataAccessLayer = new DBUtils();
            return dataAccessLayer.ProductSelectAll();
        }


        public static void insertProduct(Product newProduct)
        {
            DBUtils dataAccessLayer = new DBUtils();
            dataAccessLayer.ProductInsert(newProduct);
        }

        /// <summary>
        /// Deletes an existing product
        /// </summary>
        /// <param name="id">Product Id</param>
        public static void deleteProduct(Product objectToDelete)
        {
            int id = objectToDelete.Id;
            if (id < 1)
                throw new ArgumentException("Product Id must be greater than 0", "id");

            DBUtils dataAccessLayer = new DBUtils();
            dataAccessLayer.ProductDelete(id);
        }


        public static void updateProduct(Product employeeToUpdate)
        {
            if (employeeToUpdate.Id < 1)
                throw new ArgumentException("Product Id must be greater than 0", "id");

            DBUtils dataAccessLayer = new DBUtils();
            dataAccessLayer.ProductUpdate(employeeToUpdate);
        }

        public string[] getKeywords(Product prod)
        {
            return prod.Keywords.Split(',');
        }

        public static List<string> getKeywords (Product[] prod)
        {
            List<String> keywords = new List<String>();
            int length = prod.Length;
            for (int x = 0; x < length;x++)
            {
                string[] templist = prod[x].Keywords.Split(',');
                int f = templist.Length;
                for (int y = 0; y < f; y++)
                {
                    keywords.Add(templist[y]);
                }
            }
            return keywords;
        }


    }
}
using System;
using System.Collections.Generic;
using System.Web;
using SGShoesFinal.App_Code;
using SGShoesFinal.DAL;

namespace SGShoesFinal
{
    public class Category
    {
        private int _id = 0;
        private string _name = string.Empty;
        private string _description = string.Empty;
        


        public int CatId
        {
            get { return _id; }
            set { _id = value; }
        }

        public string CatName
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// Category Name
        /// </summary>
        public string CatDescription
        {
            get { return _description; }
            set { _description = value; }
        }
        /// <summary>
        /// Manfac Initial
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
        public Category( string CatName, string CatDescription)
            : this(0, CatName, CatDescription) { }

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
        public Category(int Catid, string CatName, string CatDescription)
        {
            _id = Catid;
            _name = CatName;
            _description = CatDescription;
        }
        public static List<Category> getAllCategories()
        {
            DBUtils dataAccessLayer = new DBUtils();
            return dataAccessLayer.CategorySelectAll();
        }


        public static void insertCategory(Category newCategory)
        {
            DBUtils dataAccessLayer = new DBUtils();
            dataAccessLayer.CategoryInsert(newCategory);
        }

        /// <summary>
        /// Deletes an existing product
        /// </summary>
        /// <param name="id">Product Id</param>
        public static void deleteCategory(Category objectToDelete)
        {
            int id = objectToDelete.CatId;
            if (id < 1)
                throw new ArgumentException("Product Id must be greater than 0", "id");

            DBUtils dataAccessLayer = new DBUtils();
            dataAccessLayer.CategoryDelete(objectToDelete);
        }


        public static void updateCategory(Category CategoryToUpdate)
        {
            if (CategoryToUpdate.CatId < 1)
                throw new ArgumentException("Product Id must be greater than 0", "id");

            DBUtils dataAccessLayer = new DBUtils();
            dataAccessLayer.CategoryUpdate(CategoryToUpdate);
        }

    }
}


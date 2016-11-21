using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using SGShoesFinal.App_Code;


namespace SGShoesFinal.App_Code
{
    public class BusinessLogic
    {
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


    }
}
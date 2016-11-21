using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using SGShoesFinal.App_Code;

namespace SGShoesFinal.App_Code
{
    public class DBUtils
    {
        private static readonly string _connectionString = string.Empty;

       public List<Product> ProductselectAll()
        {
            List<Product> colProduct = new List<Product>();

            SqlConnection con = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Product_Id,Category_Id, Product_Name, Manufacturer, Description_Short, Description_Long ,Unit_Weight, Unit_Price, Keywords, Image_Location_Small, Image_Location_Large FROM Product";

            // Execute command
            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int dID = (int)reader["Product_Id"];
                    int dCID = (int)reader["Category_Id"];
                    string dprod = (string)reader["Product_Name"];
                    string dmanu = (string)reader["MIDDLE_INITIAL"];
                    string dshortdes = (string)reader["FIRST_NAME"];
                    string dlongdes = (string)reader["GENDER"];

                    string dweight = (string)reader["STREET_ADDRESS"];
                    string dprice = (string)reader["STATE"];
                    string keywords = (string)reader["CITY"];
                    string dimagesmall = (string)reader["ZIP"];
                    string dimagelage = (string)reader["HOME_PHONE"];

                    colProduct.Add(new Product(dID, dCID, dmanu, dshortdes, dlongdes, dweight, dprice, keywords, dimagesmall, dimagelage, dcell, demail, ddob, dactive, drate));
                    colProduct.Add(new Product(
                        (int)reader["Product_Id"],
                        (int)reader["Category_Id"],
                        (string)reader["Product_Name"],
                        (string)reader["Manufacturer"],
                        (string)reader["Description_Short"],
                        (string)reader["Description_Long"],

                        (string)reader["Unit_Weight"],
                        (string)reader["Unit_Price"],
                        (string)reader["Keywords"],
                        (string)reader["Image_Location_Small"],
                        (string)reader["Image_Location_Large"]
                }
            }
            return colProduct;
        }

        /// <summary>
        /// Inserts an Product
        /// </summary>
        /// <param name="newProduct">Product</param>
        public void ProductInsert(Product newProduct)
        {
            // Create connection
            SqlConnection con = new SqlConnection(_connectionString);
            /*
            // Create command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT Product (FIRST_NAME,MIDDLE_INITIAL, Product_Name,GENDER,STREET_ADDRESS, CITY, STATE, ZIP, EMAIL, DOB, HOME_PHONE, CELL_PHONE, ACTIVE, HOURLY_RATE) VALUES (@FName,@Middle,@LName,@Gender,@SAdress,@City,@State,@Zip,@Email,@Dob,@HPhone,@Cell,@Active,@Rate)";

            // Add parameters
            cmd.Parameters.AddWithValue("@FName", newProduct.FName);
            cmd.Parameters.AddWithValue("@Middle", newProduct.Middle);
            cmd.Parameters.AddWithValue("@LName", newProduct.LName);
            cmd.Parameters.AddWithValue("@SAdress", newProduct.SAdress);
            cmd.Parameters.AddWithValue("@Gender", newProduct.Gender);

            cmd.Parameters.AddWithValue("@City", newProduct.City);
            cmd.Parameters.AddWithValue("@State", newProduct.State);
            cmd.Parameters.AddWithValue("@Zip", newProduct.Zip);
            cmd.Parameters.AddWithValue("@Email", newProduct.Email);
            cmd.Parameters.AddWithValue("@Dob", newProduct.DOB);

            cmd.Parameters.AddWithValue("@Hphone", newProduct.HPhone);
            cmd.Parameters.AddWithValue("@Cell", newProduct.Cell);
            cmd.Parameters.AddWithValue("@Active", newProduct.Active);
            cmd.Parameters.AddWithValue("@Rate", newProduct.Rate);

            // Execute command
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();

            } */
        }

        /// <summary>
        /// Updates an Product
        /// </summary>
        /// <param name="employeeToUpdate">Product</param>
        public void ProductUpdate(Product employeeToUpdate)
        {

            SqlConnection con = new SqlConnection(_connectionString);

/*
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Product SET FIRST_NAME=@FName,Product_Name=@LName,MIDDLE_INITIAL=@Middle,GENDER=@Gender,STREET_ADDRESS=@SAdress,CITY=@City,STATE=@State,ZIP=@Zip,EMAIL=@Email,DOB=@DOB,HOME_PHONE=@Hphone,CELL_PHONE=@Cell,ACTIVE=@Active,HOURLY_RATE=@Rate WHERE Product_Id=@Id";

            cmd.Parameters.AddWithValue("@LName", employeeToUpdate.LName);
            cmd.Parameters.AddWithValue("@FName", employeeToUpdate.FName);
            cmd.Parameters.AddWithValue("@Middle", employeeToUpdate.Middle);
            cmd.Parameters.AddWithValue("@SAdress", employeeToUpdate.SAdress);
            cmd.Parameters.AddWithValue("@Gender", employeeToUpdate.Gender);

            cmd.Parameters.AddWithValue("@State", employeeToUpdate.State);
            cmd.Parameters.AddWithValue("@City", employeeToUpdate.City);
            cmd.Parameters.AddWithValue("@Zip", employeeToUpdate.Zip);
            cmd.Parameters.AddWithValue("@Email", employeeToUpdate.Email);
            cmd.Parameters.AddWithValue("@Dob", employeeToUpdate.DOB);

            cmd.Parameters.AddWithValue("@HPhone", employeeToUpdate.HPhone);
            cmd.Parameters.AddWithValue("@Cell", employeeToUpdate.Cell);
            cmd.Parameters.AddWithValue("@Active", employeeToUpdate.Active);
            cmd.Parameters.AddWithValue("@Rate", employeeToUpdate.Rate); 


            cmd.Parameters.AddWithValue("@Id", employeeToUpdate.Id);

            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();

            } */
        }


        public void ProductDelete(int Id)
        {

            SqlConnection con = new SqlConnection(_connectionString);


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE Product WHERE Product_Id=@Id";


            cmd.Parameters.AddWithValue("@Id", Id);


            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }


        static DBUtils()
        {
            _connectionString = WebConfigurationManager.ConnectionStrings["fall16_g2ConnectionString"].ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new Exception("No connection string configured in Web.Config file");
        }
    }
}

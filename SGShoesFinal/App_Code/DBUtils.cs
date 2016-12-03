/* Product - Select, Insert
   Category -Select
 */
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

        public List<Product> ProductSelectAll()
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
                    colProduct.Add(new Product(
                        (int)reader["Product_Id"],
                        (int)reader["Category_Id"],
                        (string)reader["Product_Name"],
                        (string)reader["Manufacturer"],
                        (string)reader["Description_Short"],
                        (string)reader["Description_Long"],

                        (double)reader["Unit_Weight"],
                        (decimal)reader["Unit_Price"],
                        (string)reader["Keywords"],
                        (string)reader["Image_Location_Small"],
                        (string)reader["Image_Location_Large"]));
                }
            }
            return colProduct;
        }

        /// <summary>
        /// Inserts an Product
        /// </summary>
        /// <param name="newProduct">Product</param>
        //TODO
        public void ProductInsert(Product newProduct)
        {
            // Create connection
            SqlConnection con = new SqlConnection(_connectionString);

            // Create command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT Product(Product_Id,Category_Id, Product_Name, Manufacturer, Description_Short, Description_Long ,Unit_Weight, Unit_Price, Keywords, Image_Location_Small, Image_Location_Large) VALUES (@ProdID,@CatID,@ProdName,@Manufac,@SDescrip,@LDescrip,@Price,@Weight,@Keywords,@Spic,@Lpic)";

            // Add parameters
            cmd.Parameters.AddWithValue("@ProdID", newProduct.Id);
            cmd.Parameters.AddWithValue("@CatID", newProduct.CatId);
            cmd.Parameters.AddWithValue("@ProdName", newProduct.ProdName);
            cmd.Parameters.AddWithValue("@Manufac", newProduct.Manfac);
            cmd.Parameters.AddWithValue("@SDescrip", newProduct.ShortDescrip);

            cmd.Parameters.AddWithValue("@LDescrip", newProduct.LongDescrip);
            cmd.Parameters.AddWithValue("@Price", newProduct.unitPrice);
            cmd.Parameters.AddWithValue("@Weight", newProduct.UnitWeight);
            cmd.Parameters.AddWithValue("@Keywords", newProduct.Keywords);
            cmd.Parameters.AddWithValue("@Spic", newProduct.ImageLocSmall);

            cmd.Parameters.AddWithValue("@Lpic", newProduct.ImageLocLarge);

            // Execute command
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }
        //TODO
        /// <summary>
        /// Updates an Product
        /// </summary>
        /// <param name="ProductToUpdate">Product</param>
        public void ProductUpdate(Product ProductToUpdate)
        {

            SqlConnection con = new SqlConnection(_connectionString);

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "UPDATE Product SET Description_Short=@SDescrip,Product_Name=@ProdName,Manufacturer=@Manufac,Description_Long=@LDescrip,Unit_Weight=@Weight,Keywords=@Keywords,Unit_Price=@Price,Image_Location_Small=@SImageLoc,Image_Location_Large=@LImageLoc WHERE Product_Id=@Id";

                        cmd.Parameters.AddWithValue("@ProdName", ProductToUpdate.ProdName);
                        cmd.Parameters.AddWithValue("@SDescrip", ProductToUpdate.ShortDescrip);
                        cmd.Parameters.AddWithValue("@Manufac", ProductToUpdate.Manfac);
                        cmd.Parameters.AddWithValue("@Weight", ProductToUpdate.UnitWeight);
                        cmd.Parameters.AddWithValue("@LDescrip", ProductToUpdate.LongDescrip);

                        cmd.Parameters.AddWithValue("@Price", ProductToUpdate.unitPrice);
                        cmd.Parameters.AddWithValue("@Keywords", ProductToUpdate.Keywords);
                        cmd.Parameters.AddWithValue("@SImageLoc", ProductToUpdate.ImageLocSmall);
                        cmd.Parameters.AddWithValue("@LImageLoc", ProductToUpdate.ImageLocLarge);

                        cmd.Parameters.AddWithValue("@Id", ProductToUpdate.Id);

                        using (con)
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();

                        } 
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


        public List<Product_Detail> ProductDetSelectAll()
        {
            List<Product_Detail> colProductDet = new List<Product_Detail>();

            SqlConnection con = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Product_Detail_Id,Size, Quantity, Product_Id FROM Product_Detail";

            // Execute command
            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    /*  int dID = (int)reader["Product_Id"];
                      int dCID = (int)reader["Category_Id"];
                      string dprod = (string)reader["Product_Name"];
                      string dmanu = (string)reader["Manufacturer"];
                      string dshortdes = (string)reader["Description_Short"];
                      string dlongdes = (string)reader["Description_Long"];

                      double dweight = (double)reader["Unit_Weight"];
                      decimal dprice = (decimal)reader["Unit_Price"];
                      string keywords = (string)reader["Keywords"];
                      string dimagesmall = (string)reader["Image_Location_Small"];
                      string dimagelage = (string)reader["Image_Location_Large"]; 

                      colProduct.Add(new Product(dID, dCID, dprod, dmanu, dshortdes, dlongdes, dweight, dprice, keywords, dimagesmall, dimagelage)); */
                    colProductDet.Add(new Product_Detail(
                        (int)reader["Product_Detail_Id"],
                        (int)reader["Product_Id"],
                        (double)reader["Size"],
                        (int)reader["Quantity"]
                        ));
                }
            }
            return colProductDet;
        }

        /// <summary>
        /// Inserts an Product
        /// </summary>
        /// <param name="newProduct">Product</param>
        public void ProductDetInsert(Product_Detail newProduct)
        {
            // Create connection
            SqlConnection con = new SqlConnection(_connectionString);
            /*
            // Create command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT Product (Description_Short,Manufacturer, Product_Name,Description_Long,Unit_Weight, Keywords, Unit_Price, Image_Location_Small, EMAIL, DOB, Image_Location_Large) VALUES (@FName,@Manufac,@LName,@Gender,@SAdress,@Keywords,@State,@Zip,@Email,@Dob,@HPhone,@Cell,@Active,@Rate)";

            // Add parameters
            cmd.Parameters.AddWithValue("@FName", newProduct.FName);
            cmd.Parameters.AddWithValue("@Manufac", newProduct.Manufac);
            cmd.Parameters.AddWithValue("@LName", newProduct.LName);
            cmd.Parameters.AddWithValue("@SAdress", newProduct.SAdress);
            cmd.Parameters.AddWithValue("@Gender", newProduct.Gender);

            cmd.Parameters.AddWithValue("@Keywords", newProduct.Keywords);
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
        /// <param name="ProductDetToUpdate">Product</param>
        public void ProductDetUpdate(Product_Detail prodDetToUpdate)
        {

            SqlConnection con = new SqlConnection(_connectionString);

            /*
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "UPDATE Product SET Description_Short=@FName,Product_Name=@LName,Manufacturer=@Manufac,Description_Long=@Gender,Unit_Weight=@SAdress,Keywords=@Keywords,Unit_Price=@State,Image_Location_Small=@Zip,EMAIL=@Email,DOB=@DOB,Image_Location_Large=@Hphone WHERE Product_Id=@Id";

                        cmd.Parameters.AddWithValue("@LName", ProductDetToUpdate.LName);
                        cmd.Parameters.AddWithValue("@SDescrip", ProductDetToUpdate.FName);
                        cmd.Parameters.AddWithValue("@Manufac", ProductDetToUpdate.Manufac);
                        cmd.Parameters.AddWithValue("@SAdress", ProductDetToUpdate.SAdress);
                        cmd.Parameters.AddWithValue("@Gender", ProductDetToUpdate.Gender);

                        cmd.Parameters.AddWithValue("@State", ProductDetToUpdate.State);
                        cmd.Parameters.AddWithValue("@Keywords", productDetToUpdate.Keywords);
                        cmd.Parameters.AddWithValue("@Zip", productDetToUpdate.Zip);
                        cmd.Parameters.AddWithValue("@Email", productDetToUpdate.Email);
                        cmd.Parameters.AddWithValue("@Dob", productDetToUpdate.DOB);

                        cmd.Parameters.AddWithValue("@HPhone", productDetToUpdate.HPhone);
                        cmd.Parameters.AddWithValue("@Cell", productDetToUpdate.Cell);
                        cmd.Parameters.AddWithValue("@Active", productDetToUpdate.Active);
                        cmd.Parameters.AddWithValue("@Rate", productDetToUpdate.Rate); 


                        cmd.Parameters.AddWithValue("@Id", productDetToUpdate.Id);

                        using (con)
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();

                        } */
        }


        public void ProductDetDelete(int Id)
        {

            SqlConnection con = new SqlConnection(_connectionString);


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE Product_Detail WHERE Product_Detail_Id=@Id";


            cmd.Parameters.AddWithValue("@Id", Id);


            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }



        public List<Category> CategorySelectAll()
        {
            List<Category> colCategory = new List<Category>();

            SqlConnection con = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Category_Id, Category_Name, Category_Description FROM Category";

            // Execute command
            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    colCategory.Add(new Category(
                        (int)reader["Category_Id"],
                        (string)reader["Category_Name"],
                        (string)reader["Category_Description"]));
                }
            }
            return colCategory;
        }
        public void CategoryUpdate(Category CategoryToUpdate)
        {
            SqlConnection con = new SqlConnection(_connectionString);


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Category SET Description_Short=@CatId,CatName=@CatDesc WHERE Category_Id=@CatId";

            cmd.Parameters.AddWithValue("@CatId", CategoryToUpdate.CatId);
            cmd.Parameters.AddWithValue("@CatName", CategoryToUpdate.CatName);
            cmd.Parameters.AddWithValue("@CatDesc", CategoryToUpdate.CatDescription);

            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }
        
    
        public void CategoryDelete(Category cat)
        {
            SqlConnection con = new SqlConnection(_connectionString);


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE Category WHERE Category_Id=@CatId";


            cmd.Parameters.AddWithValue("@CatId", cat.CatId);


            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }

         public void CategoryInsert(Category newCategory)
        {
            // Create connection
            SqlConnection con = new SqlConnection(_connectionString);

            // Create command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT Category(Category_Id, Category_Name, Category_Description) VALUES (@CatID,@CatName,@CatDesc)";

            // Add parameters
            cmd.Parameters.AddWithValue("@CatId", newCategory.CatId);
            cmd.Parameters.AddWithValue("@CatName", newCategory.CatName);
            cmd.Parameters.AddWithValue("@CatDesc", newCategory.CatDescription);

            // Execute command
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }


        public List<Customer> CustomerSelectAll()
        {
            List<Customer> colCustomer = new List<Customer>();

            SqlConnection con = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Customer_Id, First_Name, Last_Name, Customer_Type, Shipping_Address, Billing_Address, Phone, Email, Username, Password, Website, Credit_Approval, Status_Flag FROM Customer";

            // Execute command
            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    colCustomer.Add(new Customer(
                        (int)reader["Customer_Id"],
                        (string)reader["First_Name"],
                        (string)reader["Last_Name"],
                        (string)reader["Customer_Type"],
                        (string)reader["Shipping_Address"],
                        (string)reader["Billing_Address"],
                        (string)reader["Phone"],
                        (string)reader["Email"],
                        (string)reader["Username"],
                        (string)reader["Website"],
                        (bool)reader["CreditApproval"],
                        (string)reader["Status_Flag"]));
                }
            }
            return colCustomer;
        }
        void CustomerUpdate(Customer custToUpdate)
        {
            SqlConnection con = new SqlConnection(_connectionString);

                      SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "UPDATE Customer SET Description_Short=@Cust_Id,First_Name=@Last_Name,Cust_Type=@Ship_Add,Bill_Add=@Phone,Email=@Username,Password=@Website,Credit_Approval=@Status_Flag WHERE Customer_Id=@Cust_Id";

                        cmd.Parameters.AddWithValue("@Cust_Id", custToUpdate.CustId);
                        cmd.Parameters.AddWithValue("@First_Name", custToUpdate.CustFirstName);
                        cmd.Parameters.AddWithValue("@Last_Name", custToUpdate.CustLastName);
                        cmd.Parameters.AddWithValue("@Cust_Type", custToUpdate.CustType);
                        cmd.Parameters.AddWithValue("@ShipAdd", custToUpdate.CustShippingAddress);

                        cmd.Parameters.AddWithValue("@Bill_Add", custToUpdate.CustBillingAddress);
                        cmd.Parameters.AddWithValue("@Phone", custToUpdate.CustPhone);
                        cmd.Parameters.AddWithValue("@Email", custToUpdate.CustEmail);
                        cmd.Parameters.AddWithValue("@Username", custToUpdate.CustUsername);
                        cmd.Parameters.AddWithValue("@Password", custToUpdate.CustPass);

                        cmd.Parameters.AddWithValue("@Website", custToUpdate.CustWebsite);
                        cmd.Parameters.AddWithValue("@Credit_Approval", custToUpdate.CustCreditApproval);
                        cmd.Parameters.AddWithValue("@Status_Flag", custToUpdate.CustStatusFlag); 

                        using (con)
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();

                        } 
        }

        void CustomerDelete(Customer custToDelete)
        {
            SqlConnection con = new SqlConnection(_connectionString);


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE Customer WHERE Customer_Id=@CustId";


            cmd.Parameters.AddWithValue("@CustId", custToDelete.CustId );


            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }

        public void CustomerInsert(Customer newCustomer)
        {
        // Create connection
        SqlConnection con = new SqlConnection(_connectionString);

        // Create command
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "INSERT Customer(Customer_Id, First_Name, Last_Name, Customer_Type, Shipping_Address, Billing_Address, Phone, Email, Username, Password, Website, Credit_Approval, Status_Flag) VALUES (@CustId,@FirstName,@LastName,@CustType,@ShipAdd,@BillAdd,@Phone,@Email,@Username,@Password,@Website,@CredApp, @StatusFlag)";

        // Add parameters
        cmd.Parameters.AddWithValue("@CustID", newCustomer.CustId);
        cmd.Parameters.AddWithValue("@FirstName", newCustomer.CustFirstName);
        cmd.Parameters.AddWithValue("@LastName", newCustomer.CustLastName);
        cmd.Parameters.AddWithValue("@CustType", newCustomer.CustType);
        cmd.Parameters.AddWithValue("@ShipAdd", newCustomer.CustShippingAddress);

        cmd.Parameters.AddWithValue("@BillAdd", newCustomer.CustBillingAddress);
        cmd.Parameters.AddWithValue("@Phone", newCustomer.CustPhone);
        cmd.Parameters.AddWithValue("@Email", newCustomer.CustEmail);
        cmd.Parameters.AddWithValue("@Username", newCustomer.CustUsername);
        cmd.Parameters.AddWithValue("@Password", newCustomer.CustPass);
        cmd.Parameters.AddWithValue("@Website", newCustomer.CustWebsite);
        cmd.Parameters.AddWithValue("@CredApp", newCustomer.CustCreditApproval);
        cmd.Parameters.AddWithValue("@StatusFlag", newCustomer.CustStatusFlag);
   

        // Execute command
        using (con)
        {
            con.Open();
            cmd.ExecuteNonQuery();

        }
    }

        public List<Order> OrderSelectAll()
        {
            List<Order> colOrder = new List<Order>();

            SqlConnection con = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Order_Id, Customer_Id, Product_Id, Quantity, Sale_Date, Order_Status FROM Order";

            // Execute command
            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    colOrder.Add(new Order(
                        (int)reader["Order_Id"],
                        (int)reader["Customer_Id"],
                        (int)reader["Product_Id"],
                        (int)reader["Quantity"],
                        (DateTime)reader["Sale_Date"],
                        (string)reader["Order_Status"]));
                }
            }
            return colOrder;
        }
        void OrderUpdate()
        { }

        void OrderDelete()
        { }

        public void OrderInsert(Order newOrder)
        {
            // Create connection
            SqlConnection con = new SqlConnection(_connectionString);

            // Create command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT Order(Order_Id, Customer_Id, Product_Id, Quantity, Sale_Date, Order_Status) VALUES (@OrderId,@CustId,@ProdId,@Quantity,@SaleDate,@OrderStatus)";

    // Add parameters
    cmd.Parameters.AddWithValue("@OrderId", newOrder.OrderId);
    cmd.Parameters.AddWithValue("@CustId", newOrder.CustId);
    cmd.Parameters.AddWithValue("@ProdId", newOrder.ProdId);
    cmd.Parameters.AddWithValue("@Quantity", newOrder.Quantity);
    cmd.Parameters.AddWithValue("@SaleDate", newOrder.SaleDate);

    cmd.Parameters.AddWithValue("@OrderStatus", newOrder.OrderStatus);
 

    // Execute command
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


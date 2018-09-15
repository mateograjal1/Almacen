using Almacen.Logic.DatabaseObjects;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Almacen.Logic
{
    public class DBConnection
    {
        private static string CONNECTION_STRING = "Data Source=localhost;Initial Catalog = AlmacenDB; Integrated Security = True";
        private static DBConnection db = new DBConnection();

        private SqlConnection cnn;
        private SqlCommand command;
        private SqlDataReader reader;

        private DBConnection()
        {

        }

        public static bool Connect()
        {
            try
            {
                db.cnn = new SqlConnection(CONNECTION_STRING);
                db.cnn.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static DataTable GetStock()
        {
            if (Connect())
            {
                db.command = new SqlCommand("ShowStock", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.ExecuteNonQuery();
                db.reader = db.command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(db.reader);                
                return dt;
            }
            return null;
        }

        public static DataTable GetCategories()
        {
            if (Connect())
            {
                db.command = new SqlCommand("GetCategories", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.ExecuteNonQuery();
                db.reader = db.command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(db.reader);
                return dt;
            }
            return null;
        }

        public static DataTable GetStatuses()
        {
            if (Connect())
            {
                db.command = new SqlCommand("GetStatuses", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.ExecuteNonQuery();
                db.reader = db.command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(db.reader);
                return dt;
            }
            return null;
        }

        public static DataTable GetRoles()
        {
            if (Connect())
            {
                db.command = new SqlCommand("GetRoles", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.ExecuteNonQuery();
                db.reader = db.command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(db.reader);
                return dt;
            }
            return null;
        }

        public static DataTable GetUsers()
        {
            if (Connect())
            {
                db.command = new SqlCommand("GetUserId", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.ExecuteNonQuery();
                db.reader = db.command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(db.reader);
                return dt;
            }
            return null;
        }

        public static DataTable getStaff()
        {
            if (Connect())
            {
                db.command = new SqlCommand("GetStaff", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.ExecuteNonQuery();
                db.reader = db.command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(db.reader);
                return dt;
            }
            return null;
        }

        public static DataTable getItems()
        {
            if (Connect())
            {
                db.command = new SqlCommand("GetItems", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.ExecuteNonQuery();
                db.reader = db.command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(db.reader);
                return dt;
            }
            return null;
        }

        public static DataTable getItem(int id)
        {
            if (Connect())
            {
                db.command = new SqlCommand("GetItem", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.Parameters.AddWithValue("Id", id);
                db.command.ExecuteNonQuery();
                db.reader = db.command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(db.reader);
                return dt;
            }
            return null;
        }


        public static int DeleteItem(int id)
        {
            if (Connect())
            {
                db.command = new SqlCommand("DeleteItem", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.Parameters.AddWithValue("Id", id);
                return db.command.ExecuteNonQuery();
            }
            return -1;
        }

        public static DataTable CheckLogIn(string user, string password)
        {
            if (Connect())
            {
                db.command = new SqlCommand("CheckLogIn", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.Parameters.AddWithValue("user", user);
                db.command.Parameters.AddWithValue("password", password);
                db.command.ExecuteNonQuery();
                db.reader = db.command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(db.reader);
                return dt;
            }
            return null;
        }

        public static DataTable GetItemStock()
        {
            if (Connect())
            {
                db.command = new SqlCommand("GetStock", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.ExecuteNonQuery();
                db.reader = db.command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(db.reader);
                return dt;
            }
            return null;
        }

        public static int AddPerson(Person person, string user, string password)
        {
            if (Connect())
            {
                db.command = new SqlCommand("AddPerson", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.Parameters.AddWithValue("Name", person.Name);
                db.command.Parameters.AddWithValue("LastName", person.LastName);
                db.command.Parameters.AddWithValue("DOB", person.Dob);
                db.command.Parameters.AddWithValue("Address", person.Address);
                db.command.Parameters.AddWithValue("Email", person.Email);
                db.command.Parameters.AddWithValue("Phone", person.Phone);
                db.command.Parameters.AddWithValue("RoleId", person.RoleId);
                db.command.Parameters.AddWithValue("UserId", user);
                db.command.Parameters.AddWithValue("Password", password);
                return db.command.ExecuteNonQuery();
            }
            return -1;
        }

        public static int AddItem(Item item)
        {
            //@Name nvarchar(50), @Description nvarchar(250), @StorePrice decimal(18,0), @CustomerPrice decimal(18,0), @Category int, @Status int
            if (Connect())
            {
                db.command = new SqlCommand("AddItem", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.Parameters.AddWithValue("Name", item.Name);
                db.command.Parameters.AddWithValue("Description", item.Description);
                db.command.Parameters.AddWithValue("StorePrice", item.StorePrice);
                db.command.Parameters.AddWithValue("CustomerPrice", item.CustomerPrice);
                db.command.Parameters.AddWithValue("Category", item.Category.CategoryId);
                db.command.Parameters.AddWithValue("Status", item.Status.StatusId);
                return db.command.ExecuteNonQuery();
            }
            return -1;
        }

        public static int AddCategory(string name)
        {
            if (Connect())
            {
                db.command = new SqlCommand("AddCategory", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.Parameters.AddWithValue("Name", name);
                return db.command.ExecuteNonQuery();
            }
            return -1;
        }
        public static int AddStatus(string name)
        {
            if (Connect())
            {
                db.command = new SqlCommand("AddStatus", db.cnn);
                db.command.CommandType = CommandType.StoredProcedure;
                db.command.Parameters.AddWithValue("Name", name);
                return db.command.ExecuteNonQuery();
            }
            return -1;
        }

        public static void UpdateStock(List<Stock> list)
        {
            if (Connect())
            {
                foreach (Stock s in list)
                {
                    db.command = new SqlCommand("UpdateStock", db.cnn);
                    db.command.CommandType = CommandType.StoredProcedure;
                    db.command.Parameters.AddWithValue("Id", s.Id);
                    db.command.Parameters.AddWithValue("Amount", s.Amount);
                    db.command.Parameters.AddWithValue("Date", s.Date);
                    db.command.ExecuteNonQuery();
                }
                
                
            }
        }

    }
}

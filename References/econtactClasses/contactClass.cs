using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace econtact.References.econtactClasses
{
    internal class contactClass
    {
        //getter setter properties
        //acts as data carrier in our application
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //select data from database
        public DataTable Select()
        {
            //step1 database connection
            SQLiteConnection conn = new SQLiteConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //step 2 writing sql quarry
                string sql = "SELECT * FROM tbl_contact";
                //creating cmd using sql and conn
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                //creating sql dataadapter using cmd
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();   
            }
            return dt;
        }
        //inserting data into database
        public bool Insert (contactClass c)
        {
            //creating a default return type and returing its value to false
            bool isSuccess = false;
            //step 1 connect database
            SQLiteConnection conn = new SQLiteConnection(myconnstring);
            try 
            {
                //step2 a sql quarry to insert data
                string sql = "INSERT INTO tbl_contact (Firstname, Lastname, ContactNo, Address, Gender) VALUES (@Firstname, @Lastname, @ContactNo, @Address, @Gender)";
                //creating sql command using sql and conn
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@Firstname", c.FirstName);
                cmd.Parameters.AddWithValue("@Lastname", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue ("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                //connection open here
                conn.Open();
                int rows= cmd.ExecuteNonQuery();
                //if the quarry runs seccessfully value of rows >0 else rows=0
                if (rows > 0) 
                {
                    isSuccess = true;   
                }
                else 
                {
                    isSuccess= false;
                }
            }
            catch (Exception ex) 
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //method to update database from application

        public bool Update(contactClass c)
        {
            //creating a default return type and returing its value to false
            bool isSuccess = false;
            //step 1 connect database
            SQLiteConnection conn = new SQLiteConnection(myconnstring);
            try
            {
                //step2 a sql quarry to update data
                string sql = "UPDATE tbl_contact SET Firstname=@Firstname, Lastname=@Lastname, ContactNo=@ContactNo, Address=@Address, Gender=@Gender WHERE ContactID=@ContactID";
                //creating sql command using sql and conn
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                //create parameters to add VALUE
                cmd.Parameters.AddWithValue("@Firstname", c.FirstName);
                cmd.Parameters.AddWithValue("@Lastname", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactId);
                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the quarry runs seccessfully value of rows >0 else rows=0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //method to delete data from database
        public bool Delete(contactClass c)
        {
            //creating a default return type and returing its value to false
            bool isSuccess = false;
            //step 1 connect database
            SQLiteConnection conn = new SQLiteConnection(myconnstring);
            try
            {
                //step2 a sql quarry to delete data
                string sql = "DELETE FROM tbl_contact WHERE ContactID=@ContactID";
                //creating sql command using sql and conn
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                //create parameters to add VALUE
                cmd.Parameters.AddWithValue("@ContactID", c.ContactId);
                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the quarry runs seccessfully value of rows >0 else rows=0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}

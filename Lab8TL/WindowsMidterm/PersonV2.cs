using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsMidterm
{
    class PersonV2 : ClassMidterm
    {
        private string cellphone;
        private string instagramurl;
        private Int32 personid;
        public string CellPhone
        {
            get
            {
                return cellphone;
            }
            set
            {
                if (ValidationLibrary.iscellphoneValid(value))
                {
                    cellphone = value;
                }
                else
                {
                    Feedback = "ERROR: Invalid Cellphone Format:";


                }
            }
        }

        public string InstagramURL
        {
            get
            {
                return instagramurl;
            }
            set
            {
                if (ValidationLibrary.isinstaurlValid(value))
                {
                    instagramurl = value;
                }
                else
                {
                    Feedback = "ERROR: Invalid URL Format:";


                }
            }
        }
        public Int32 PersonID
        {
            get
            {
                return personid;
            }

            set
            {
               
                if (value >= 0)
                {
                    personid = value;  
                }
                else
                {
                    
                    Feedback += "\nERROR: ";
                }
            }
        }
        public string AddARecord()
        {
            //Init string var
            string strResult = "";

            //Make a connection object
            SqlConnection Conn = new SqlConnection();

            //Initialize it's properties
            Conn.ConnectionString = @"Server=sql.neit.edu,4500;Database=SE245_TLeBrun;User Id=SE245_TLeBrun;Password=008007049;";     //Set the Who/What/Where of DB

            string strSQL = "INSERT INTO [SE245_TLeBrun].[dbo].[C#Week 7] (FirstName, MiddleName, LastName, Street1, Street2, City, State, ZipCode, Phone, Email, Instagram) VALUES (@Firstname, @Middlename, @Lastname, @Street1, @Street2, @City, @State, @Zip, @Phone, @Email, @InstagramURL)";
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn;

            comm.Parameters.AddWithValue("@Firstname", Firstname);
            comm.Parameters.AddWithValue("@Middlename", Middlename);
            comm.Parameters.AddWithValue("@Lastname", Lastname);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@InstagramURL", InstagramURL);


            //attempt to connect to the server
            try
            {
                Conn.Open();                                       //Open connection to DB - Think of dialing a friend on phone
                int intRecs = comm.ExecuteNonQuery();
                strResult = "SUCCESS: Connected to Database";       //Report that we made the connection
                Conn.Close();                                       //Hanging up after phone call
            }
            catch (Exception err)                                   //If we got here, there was a problem connecting to DB
            {
                strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
            }
            finally
            {

            }



            //Return resulting feedback string
            return strResult;


        }
        public DataSet SearchPerson(String strFirst, String strLast)
        {
            //Create a dataset to return filled
            DataSet ds = new DataSet();


            //Create a command for our SQL statement
            SqlCommand comm = new SqlCommand();


            //Write a Select Statement to perform Search
            String strSQL = "SELECT * FROM [SE245_TLeBrun].[dbo].[C#Week 7] WHERE 0=0";

            //If the First/Last Name is filled in include it as search criteria
            if (strFirst.Length > 0)
            {
                strSQL += " AND FirstName LIKE @Firstname";
                comm.Parameters.AddWithValue("@Firstname", "%" + strFirst + "%");
            }
            if (strLast.Length > 0)
            {
                strSQL += " AND LastName LIKE @Lastname";
                comm.Parameters.AddWithValue("@Lastname", "%" + strLast + "%");
            }
            //Create DB tools and Configure
            //*********************************************************************************************
            SqlConnection conn = new SqlConnection();
            //Create the who, what where of the DB
            string strConn = @GetConnected();
            conn.ConnectionString = strConn;

            //Fill in basic info to command object
            comm.Connection = conn;     //tell the commander what connection to use
            comm.CommandText = strSQL;  //tell the command what to say

            //Create Data Adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;    //commander needs a translator(dataAdapter) to speak with datasets

            //*********************************************************************************************

            //Get Data
            conn.Open();                //Open the connection (pick up the phone)
            da.Fill(ds, "Search_Temp");     //Fill the dataset with results from database and call it "EBooks_Temp"
            conn.Close();               //Close the connection (hangs up phone)

            //Return the data
            return ds;
        }

        private string GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE245_TLeBrun;User Id=SE245_TLeBrun;Password=008007049;";
        }

        public SqlDataReader FindOnePerson(int intPerson_ID)
        {
            //Create and Initialize the DB Tools we need
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //My Connection String
            string strConn = GetConnected();

            //My SQL command string to pull up one Persons data
            string sqlString =
           "SELECT * FROM [SE245_TLeBrun].[dbo].[C#Week 7] WHERE PersonID = @PersonID;";

            //Tell the connection object the who, what, where, how
            conn.ConnectionString = strConn;

            //Give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PersonID", intPerson_ID);

            //Open the DataBase Connection and Yell our SQL Command
            conn.Open();

            //Return some form of feedback
            return comm.ExecuteReader();   //Return the dataset to be used by others (the calling form)

        }
        public string UpdateARecord()
        {
            //Init string var
            string strResult = "";
            Int32 intRecords = 0;

            //Make a connection object
            SqlConnection Conn = new SqlConnection();

            //Initialize it's properties
            Conn.ConnectionString = @"Server=sql.neit.edu,4500;Database=SE245_TLeBrun;User Id=SE245_TLeBrun;Password=008007049;";     //Set the Who/What/Where of DB

            string strSQL = "UPDATE [SE245_TLeBrun].[dbo].[C#Week 7] SET FirstName = @FirstName, MiddleName = @Middlename, Lastname = @Lastname, Street1 = @Street1, Street2 = @Street2, City = @City, State = @State, ZipCode = @Zip, Phone = @Phone, Email = @Email, Instagram = @InstagramURL WHERE PersonID = @PersonID";
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn; 

            comm.Parameters.AddWithValue("@Firstname", Firstname);
            comm.Parameters.AddWithValue("@Middlename", Middlename);
            comm.Parameters.AddWithValue("@Lastname", Lastname);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@InstagramURL", InstagramURL);
            comm.Parameters.AddWithValue("@PersonID", PersonID);


            //attempt to connect to the server
            try
            {
                Conn.Open();                                       //Open connection to DB - Think of dialing a friend on phone
                int intRecs = comm.ExecuteNonQuery();
                strResult = "Records Updated";       //Report that we made the connection
                Conn.Close();                                       //Hanging up after phone call
            }
            catch (Exception err)                                   //If we got here, there was a problem connecting to DB
            {
                strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
            }
            finally
            {

            }



            //Return resulting feedback string
            return strResult;


        }
        public string DeleteOnePerson(int intPerson_ID)
        {
            Int32 intRecords = 0;
            string strResult = "";

            //Create and Initialize the DB Tools we need
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //My Connection String
            string strConn = GetConnected();

            //My SQL command string to pull up one EBook's data
            string sqlString =
           "DELETE FROM [SE245_TLeBrun].[dbo].[C#Week 7] WHERE PersonID = @PersonID;";

            //Tell the connection object the who, what, where, how
            conn.ConnectionString = strConn;

            //Give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PersonID", intPerson_ID);

            try
            {
                //Open the connection
                conn.Open();

                //Run the Delete and store the number of records effected
                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + " Records Deleted.";
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
            }
            finally
            {
                //close the connection
                conn.Close();
            }

            return strResult;


        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsMidterm
{
    class PersonV2:ClassMidterm
    {
        private string cellphone;
        private string instagramurl;
        public string CellPhone
        {
            get
            {
                return cellphone;
            }
            set
            {
                cellphone = value;
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
                    Feedback = "ERROR: Invalid Email Format:";


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
    }
}

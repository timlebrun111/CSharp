//Create the person structure
//Create string values for 
//First name
// name
//Last name
//Street1
//Street 2
//City
//State
//Zip
//Phone
//Email
//Allow the user to confirm that the data is correct/inputted correctly.
//Make sure I convert the structure “Person” into a class
//If the code works, make the variable First Name has the word “Poopy” in it
//Once everything works from the previous steps, convert the class properties to “Private”
//Generate the Gets/Sets which allows the gathering of the private data.
//Check to see if everything runs correctly after the program is finished

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4TL
{
    class ValidationLibrary
    {
        public static bool isEmailValid(string temp)
        {
            bool blnResult = true;

            int atLoc = temp.IndexOf("@");
            int NextatLoc = temp.IndexOf("@", atLoc + 1);

            int periodloc = temp.LastIndexOf(".");

            if (temp.Length < 8)
            {
                blnResult = false;
            }
            else if (atLoc < 2)
            {
                blnResult = false;
            }
            else if (periodloc + 2 > (temp.Length))
            {
                blnResult = false;
            }
            return blnResult;
        }

        public static bool isZipValid(string temp)
        {
            bool blnResult = true;

            if (temp.Length < 5)
            {
                blnResult = false;
            }

            return blnResult;
        }

        public static bool isPhoneValid(string temp)
        {
            bool blnResult = true;

            if (temp.Length < 10)
            {
                blnResult = false;
            }

            return blnResult;
        }
    }
    class Program
    {
        public class Person
        {
            
            private string firstname;
            private string middlename;
            private string lastname;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private string zip;
            private string phone;
            private string email;

            public string Firstname
            {
                get
                {
                    return firstname;
                }
                set
                {
                    firstname = value;
                }
            }

            public string Middlename
            {
                get
                {
                    return middlename;
                }
                set
                {
                    middlename = value;
                }
            }
            public string Lastname
            {
                get
                {
                    return lastname;
                }
                set
                {
                    lastname = value;
                }
            }
            public string Street1
            {
                get
                {
                    return street1;
                }
                set
                {
                    street1 = value;
                }
            }
            public string Street2
            {
                get
                {
                    return street2;
                }
                set
                {
                    street2 = value;
                }
            }
            public string City
            {
                get
                {
                    return city;
                }
                set
                {
                    city = value;
                }
            }
            public string State
            {
                get
                {
                    return state;
                }
                set
                {
                    state = value;
                }
            }
            public string Zip
            {
                get
                {
                    return zip;
                }
                set
                {
                    if (ValidationLibrary.isZipValid(value))
                    {
                        zip = value;
                    }
                    else
                    {
                        zip = "Invalid input";
                    }
                }
            }
            public string Phone
            {
                get
                {
                    return phone;
                }
                set
                {
                    if (ValidationLibrary.isPhoneValid(value))
                    {
                        phone = value;
                    }
                    else
                    {
                        phone = "Invalid input";
                    }
                }
            }
            public string Email
            {
                get
                {
                    return email;
                }
                set
                {
                    if (ValidationLibrary.isEmailValid(value))
                    {
                        email = value;
                    }
                    else
                    {
                        email = "Invalid input";
                    }
                        
                }

            }
        }
        static void Main(string[] args)
        {
           
            


            Person temp = new Person();


            Console.Write("\nPlease enter your First Name: ");
            temp.Firstname = Console.ReadLine();

            //temp.Firstname = temp.Firstname + "Poopy";

            Console.Write("\nPlease enter your Middle Name: ");
            temp.Middlename = Console.ReadLine();

            Console.Write("\nPlease enter your Last Name: ");
            temp.Lastname = Console.ReadLine();

            Console.Write("\nPlease enter your first Street: ");
            temp.Street1 = Console.ReadLine(); 

            Console.Write("\nPlease enter your second Street: ");
            temp.Street2 = Console.ReadLine();

            Console.Write("\nPlease enter the name of the City you live in: " );
            temp.City = Console.ReadLine();

            Console.Write("\nPlease enter the state that you live in: ");
            temp.State = Console.ReadLine();

            Console.Write("\nPlease enter your Zipcode: ");
            temp.Zip = Console.ReadLine();

            Console.Write("\nPlease enter your Phone Number: ");
            temp.Phone  = Console.ReadLine();

            Console.Write("\nPlease enter your Email: ");
            temp.Email = Console.ReadLine();

            Console.Write("\n\nThis is the information that has been gathered:");
            Console.Write($"\nFirst Name: {temp.Firstname}");
            Console.Write($"\nMiddle Name: {temp.Middlename}");
            Console.Write($"\nLast Name: {temp.Lastname}");
            Console.Write($"\nFirst Street: {temp.Street1}");
            Console.Write($"\nSecond Street: {temp.Street2}");
            Console.Write($"\nCity: {temp.City}");
            Console.Write($"\nState: {temp.State}");
            Console.Write($"\nZipcode: {temp.Zip}");
            Console.Write($"\nPhone Number: {temp.Phone}");
            Console.Write($"\nEmail: {temp.Email}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsMidterm
{
    class ClassMidterm
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
        private string feedback= "";

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                if(ValidationLibrary.iswordsValid(value))
                {
                    firstname = value;
                }
                else
                {
                    Feedback = "ERROR: Invalid Words Used";
                }
            }
        }

        public string Feedback
        {
            get
            {
                return feedback;
            }
            set
            {
                feedback = value;
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
                if (ValidationLibrary.iswordsValid(value))
                {
                    firstname = value;
                }
                else
                {
                    Feedback = "ERROR: Invalid Words Used";
                }
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
                if (ValidationLibrary.iswordsValid(value))
                {
                    firstname = value;
                }
                else
                {
                    Feedback = "ERROR: Invalid Words Used";
                }
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
                if (ValidationLibrary.isStateValid(value))
                {
                    state = value;
                }
                else
                {
                    Feedback = "ERROR: Invalid State Format";
                }
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
                    Feedback = "ERROR: Invalid ZipCode Format";
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
                    Feedback = "ERROR: Invalid Phone Number Format:";
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
                    Feedback = "ERROR: Invalid Email Format:";


                }
            }

        }
    }
}
    


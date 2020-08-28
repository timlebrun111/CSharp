using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

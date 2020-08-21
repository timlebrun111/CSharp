using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMidterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            ClassMidterm temp = new ClassMidterm();
            temp.Firstname = txtfirstname.Text;
            temp.Middlename = txtmiddlename.Text;
            temp.Lastname = txtlastname.Text;
            temp.Street1 = txtstreet1.Text;
            temp.Street2 = txtstreet2.Text;
            temp.City = txtcity.Text;
            temp.State = txtstate.Text;
            temp.Zip = txtzip.Text;
            temp.Phone = txtphone.Text;
            temp.Email = txtemail.Text;

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = "Person added: \n"+temp.Firstname+" "+temp.Lastname+"\n"+temp.Street1+"\n"+temp.City+" "+temp.State+"\n"+temp.Zip+"\n"+temp.Phone+"\n"+temp.Email;

                lblbye.Text = BasicToolsMidterm1.pause(); 
            }

        }

       
    }
}

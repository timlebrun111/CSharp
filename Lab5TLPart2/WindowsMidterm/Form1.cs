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
            Customer temp = new Customer();
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
            temp.CellPhone = txtcellphone.Text;
            temp.InstagramURL = txtinstagramurl.Text;
            temp.CustomerSince = dtpcustomersince.Value;
            temp.DiscountMember = cboxdiscountmember.Checked;
            temp.RewardsEarned = Int32.Parse(txtrewardsearned.Text);

            double dblprice;
                if(Double.TryParse(txttotalpurchases.Text, out dblprice) == true)
                {
                temp.TotalPurchases = dblprice;
                }
                else
                {
                temp.TotalPurchases = 0;
                temp.Feedback = "ERORR: Invalid Price. Ex: 5.99";
                }
            bool DiscountMember = cboxdiscountmember.Checked;
            

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = "Person added: \n" + temp.Firstname + " " + temp.Lastname + "\n" + temp.Street1 + "\n" + temp.City + " " + temp.State + "\n" + temp.Zip + "\n" + temp.CellPhone + " " + temp.Phone + "\n" + temp.Email + "\n" + temp.InstagramURL + "\nCustomer Since: " + temp.CustomerSince + "\n$ " + temp.TotalPurchases + "\nDiscount Member: " + temp.DiscountMember + "\nRewards Earned: " + temp.RewardsEarned;
                    

                lblbye.Text = BasicToolsMidterm1.pause(); 
            }

            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

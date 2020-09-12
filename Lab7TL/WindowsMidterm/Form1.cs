﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsMidterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Int32 intPerson_ID)
        {
            InitializeComponent();

            PersonV2 temp = new PersonV2();
            SqlDataReader dr = temp.FindOnePerson(intPerson_ID);

            while( dr.Read())
            {
                txtfirstname.Text = dr["Firstname"].ToString();
                txtlastname.Text = dr["Lastname"].ToString();
            }
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
                lblFeedback.Text = temp.AddARecord();
                    

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

        private void txtrewardsearned_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtzip_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtzip.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtzip.Text = txtzip.Text.Remove(txtzip.Text.Length - 1);
            }
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtphone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtphone.Text = txtphone.Text.Remove(txtphone.Text.Length - 1);
            }
        }
    }
}

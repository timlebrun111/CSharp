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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strPerson_ID = dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show(strPerson_ID);

            int intPerson_ID = Convert.ToInt32(strPerson_ID);
            Form1 Editor = new Form1(intPerson_ID);
            Editor.ShowDialog();
        }
    

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //Get Data
            PersonV2 temp = new PersonV2();
            //Perform the search we created in EBook class and store the returned dataset
            DataSet ds = temp.SearchPerson(txtFirst.Text, txtLast.Text);

            //Display data (dataset)
            dgvResults.DataSource = ds;                                  //point datagrid to dataset
            dgvResults.DataMember = ds.Tables["Search_Temp"].ToString();     // What table in the dataset?
        }
    }
}

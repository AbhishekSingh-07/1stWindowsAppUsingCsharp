using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp3
{
    public partial class addcustomers : Form
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataTable cust;
        public addcustomers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string custid, custname, custcontnum, custemail, custaddr;
            custid = txtcustid.Text;
            custname = txtcustname.Text;
            custcontnum = txtcustcontnum.Text;
            custemail = txtcustemail.Text;
            custaddr = txtcustaddr.Text;
            try
            {
                dr = cust.NewRow();
                dr[0] = int.Parse(custid);
                dr[1] = custname;
                dr[2] = int.Parse(custcontnum);
                dr[3] = custemail;
                dr[4] = custaddr;
                cust.Rows.Add(dr);
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
            }
            clear();
        }
        private void clear()
        {
            txtcustid.Text = "";
            txtcustname.Text = "";
            txtcustcontnum.Text = "";
            txtcustemail.Text = "";
            txtcustaddr.Text = "";
        }

        private void addcustomers_Load(object sender, EventArgs e)
        {
            cust = Generatetable();
            dataGridView1.DataSource = cust;
        }

        DataTable Generatetable()
        {
            dt = new DataTable("Customers");

            dc = new DataColumn("CustId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("CustName", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("CustContNum", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("CustEmail", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("CustAddress", typeof(string));
            dt.Columns.Add(dc);

            return dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtcustid.Text, "[^0-9]"))
            {
                MessageBox.Show("do not enter non numeric vals");
                txtcustid.Text = "";
            }
        }

        private void txtcustcontnum_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtcustcontnum.Text, "[^0-9]{10}$"))
            {
                MessageBox.Show("Please enter a valid mobile number");
                txtcustcontnum.Text = "";
            }
        }

        
    }
}

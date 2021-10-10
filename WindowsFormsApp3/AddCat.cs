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
    public partial class AddCat : Form
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataTable cat;
        public AddCat()
        {
            InitializeComponent();
        }

        
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string cid, cname, cdesc;
            cid = txtcatid.Text;
            cname = txtcatname.Text;
            cdesc = txtcatdesc.Text;
            try
            {
                dr = cat.NewRow();
                dr[0] = int.Parse(cid);
                dr[1] = cname;
                dr[2] = cdesc;
                cat.Rows.Add(dr);
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
            }
            clear();
        }
        private void clear()
        {
            txtcatid.Text = "";
            txtcatname.Text = "";
            txtcatdesc.Text = "";
        }


        

        private void AddCat_Load(object sender, EventArgs e)
        {
            cat = Generatetable();
            dataGridView1.DataSource = cat;
        }
        DataTable Generatetable()
        {
            dt = new DataTable("Categories");

            dc = new DataColumn("CatId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("CatName", typeof(string));
            dt.Columns.Add(dc);
           
            dc = new DataColumn("CatDescription", typeof(string));
            dt.Columns.Add(dc);

            return dt;
        }

        private void txtcatid_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtcatid.Text, "[^0-9]"))
            {
                MessageBox.Show("do not enter non numeric vals");
                txtcatid.Text = "";
            }
        }
    }
}

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
    public partial class AddOrders : Form
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataTable order;
        public AddOrders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ordid, pid, quan;
            pid = txtpid.Text;
            ordid = txtordid.Text;
            quan = txtquan.Text;

            try
            {
                dr = order.NewRow();
                dr[0] = int.Parse(ordid);
                dr[1] = int.Parse(pid);
                dr[2] = int.Parse(quan);
                order.Rows.Add(dr);
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
            }
            clear();
        }

        private void clear()
        {
            txtpid.Text = "";
            txtordid.Text = "";
            txtquan.Text = "";
            
        }

        private void AddOrders_Load(object sender, EventArgs e)
        {
            order = Generatetable();
            dataGridView1.DataSource = order;
        }

        DataTable Generatetable()
        {
            dt = new DataTable("Order");

            dc = new DataColumn("OrderId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("ProdId", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("Quan", typeof(int));
            dt.Columns.Add(dc);

            return dt;
        }

        private void txtordid_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtordid.Text, "[^0-9]"))
            {
                MessageBox.Show("do not enter non numeric vals");
                txtordid.Text = "";
            }
        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtpid.Text, "[^0-9]"))
            {
                MessageBox.Show("do not enter non numeric vals");
                txtpid.Text = "";
            }
        }

        private void txtquan_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtquan.Text, "[^0-9]"))
            {
                MessageBox.Show("do not enter non numeric vals");
                txtquan.Text = "";
            }
        }
    }
}

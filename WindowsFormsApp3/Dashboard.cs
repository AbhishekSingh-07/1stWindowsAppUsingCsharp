using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace Project2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnaddprod_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();
        }

     

        private void btnaddcat_Click(object sender, EventArgs e)
        {
            AddCat ob = new AddCat();
            ob.Show();
        }

        private void btnaddcus_Click(object sender, EventArgs e)
        {
            addcustomers ob = new addcustomers();
            ob.Show();
        }

        private void btnaddord_Click(object sender, EventArgs e)
        {
            AddOrders ob = new AddOrders();
            ob.Show();
        }
    }
}

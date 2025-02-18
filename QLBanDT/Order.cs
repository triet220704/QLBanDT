using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLBanDT
{
    public partial class Order : Form
    {
        private string connectionstring = "Server=DESKTOP-DCQM5O9\\SQLEXPRESS;Database=QLBanDT;Trusted_Connection=True;TrustServerCertificate=True;";
        public Order()
        {
            InitializeComponent();
        }



        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homefrom home = new Homefrom();
            home.Show();
            this.Hide();
        }
    }
}



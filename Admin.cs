using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JourneyX
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guna2Button8_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button_OffersAndNews_Click(object sender, EventArgs e)
        {
            Admin admin = Application.OpenForms.OfType<Admin>().FirstOrDefault();
            if(admin != null)
            {
                admin.Activate();
            }
            else
            {
                admin = new Admin();
                admin.Show();
            }
        }

        private void Button_Profile_Click(object sender, EventArgs e)
        {
            AdminProfile admin = Application.OpenForms.OfType<AdminProfile>().FirstOrDefault();
            if(admin != null)
            {
                admin.Activate();
            }
            else
            {
                admin = new AdminProfile();
                admin.Show();
            }
        }

        private void guna2GradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

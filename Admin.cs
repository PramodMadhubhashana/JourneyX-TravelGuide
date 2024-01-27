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
        public string Email;
        public Admin( string email)
        {
            InitializeComponent();
            emtytextfeild.Visible = false;
            Email= email;
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
                admin = new Admin(Email);
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
                Profile profile = new Profile(Email);
                profile.Show();
            }
        }

        private void guna2GradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label_BestDestination_Click(object sender, EventArgs e)
        {

        }

        private void Button1_add_Click(object sender, EventArgs e)
        {
            string offers = tetboxoffers.Text.ToString();
            if (!string.IsNullOrEmpty(tetboxoffers.Text))
            {
               SQL sQL= new SQL();
               bool result = sQL.InsertOffer(offers);

                if (result)
                {
                    MessageBox.Show("Feedback submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to submit feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                emtytextfeild.Text = "please add the offers ";
            }
        }

        private void tetboxoffers_Click(object sender, EventArgs e)
        {
            emtytextfeild.Visible = false;
        }
    }
}

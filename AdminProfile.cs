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
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            TextBox_FirstName.Enabled = false;
            TextBox_lastName.Enabled = false;
            TextBox_Address.Enabled = false;
            TextBox_BirthDay.Enabled = false;
            TextBox_Email.Enabled = false;
            TextBox_PhoneNumber.Enabled = false;
            RadioButton_Femaile.Enabled = false;
            RadionButton_Male.Enabled = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button01_Click(object sender, EventArgs e)
        {

        }
    }
}

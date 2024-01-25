using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JourneyX
{
    public partial class Profile : Form
    {
        public string Email;
        public Profile(string Email)
        {
            InitializeComponent();           
        }       
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Button_PPChange_Click(object sender, EventArgs e)
        {
            ComboBox_PPicture.Visible = true;
        }
        int ppID = 0;
        private void Profile_Load(object sender, EventArgs e)
        {
            ComboBox_PPicture.SelectedIndex = 0;
            ComboBox_PPicture.Visible= false;

            if(PictureBox_PPicture.Image == null)
            {
                Button_PPChange.Text = "ADD";
            }
            else
            {
                Button_PPChange.Text = "Change";
            }

            TextBox_FirstName.Enabled = false;
            TextBox_lastName.Enabled = false;
            TextBox_Address.Enabled = false;
            TextBox_BirthDay.Enabled = false;
            TextBox_Email.Enabled = false;
            TextBox_PhoneNumber.Enabled = false;

            SQL sQL = new SQL();
            string TextJoin = sQL.PDetails(Email);
            if (TextJoin == "--Error--")
            {
                string[] parts = TextJoin.ToString().Split('+');

                TextBox_FirstName.Text = parts[1];
                TextBox_lastName.Text = parts[2];
                TextBox_Address.Text = parts[3];
                TextBox_BirthDay.Text = parts[4];
                TextBox_Email.Text = parts[1];
                TextBox_PhoneNumber.Text = parts[6];
                int PPID = Int32.Parse(parts[8]);
                PPID = ppID;
            }
            else
            {
                MessageBox.Show("An error has occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ComboBox_PPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(ComboBox_PPicture.SelectedIndex)
            {
                case 1:
                    PictureBox_PPicture.Image = Image.FromFile("C:\\Users\\PRAMOD MADHUBHASHANA\\Documents\\Visual Studio 2022\\GUI\\JourneyX\\Icons\\Picture01.png");
                    break;

                    case 2:
                        PictureBox_PPicture.Image = Image.FromFile("C:\\Users\\PRAMOD MADHUBHASHANA\\Documents\\Visual Studio 2022\\GUI\\JourneyX\\Icons\\Picture02.png");
                        break;

                        case 3:
                             PictureBox_PPicture.Image = Image.FromFile("C:\\Users\\PRAMOD MADHUBHASHANA\\Documents\\Visual Studio 2022\\GUI\\JourneyX\\Icons\\Picture03.png");
                             break;

                        case 4:
                            PictureBox_PPicture.Image = Image.FromFile("C:\\Users\\PRAMOD MADHUBHASHANA\\Documents\\Visual Studio 2022\\GUI\\JourneyX\\Icons\\Picture04.png");
                            break;

                    case 5:
                        PictureBox_PPicture.Image = Image.FromFile("C:\\Users\\PRAMOD MADHUBHASHANA\\Documents\\Visual Studio 2022\\GUI\\JourneyX\\Icons\\Picture05.png");
                        break;

                case 6:
                    PictureBox_PPicture.Image = Image.FromFile("C:\\Users\\PRAMOD MADHUBHASHANA\\Documents\\Visual Studio 2022\\GUI\\JourneyX\\Icons\\Picture06.png");
                    break;
            }
        }

        private void Button01_Click(object sender, EventArgs e)
        {
            TextBox_FirstName.Enabled = true;
        }

        private void Button02_Click(object sender, EventArgs e)
        {
            TextBox_lastName.Enabled = true;
        }

        private void Button03_Click(object sender, EventArgs e)
        {
            TextBox_Address.Enabled = true;
        }

        private void Button04_Click(object sender, EventArgs e)
        {
            RadioButton_Femaile.Enabled = true;
            RadionButton_Male.Enabled = true;
            //jhdehhh
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            Guna2TextBox[] textBoxes = { TextBox_FirstName, TextBox_lastName, TextBox_Address };
            Guna2HtmlLabel[] labels = { Label_FError, Label_LError, Label_AError };

            for(int i=0; i<textBoxes.Length; i++)
            {
                if (textBoxes[i] == null)
                {
                    labels[i].Text = "  please Fill The Details";
                }
                else
                {

                }
            }
        }
    }
}

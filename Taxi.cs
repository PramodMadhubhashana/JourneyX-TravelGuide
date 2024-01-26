using Guna.UI2.WinForms;
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
    public partial class Taxi : Form
    {
        public string Email;
        public Taxi(string email)
        {
            InitializeComponent();
            Email= email;
        }        
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Book_Click(object sender, EventArgs e)
        {
            Guna2TextBox[] textBoxes = { TextBox_Pickup, TextBox_Drop };
            Guna2HtmlLabel[] labls = { Label_PError, Label_DError };
            int nullselectTextBox = textBoxes.Count(tb => tb.Text== string.Empty);
            string pickup = TextBox_Pickup.Text.ToString();
            string drop = TextBox_Drop.Text.ToString();
            DateTime date = dateTimePicker1.Value.Date;
            int vehical= 1;

            if (RadioButton_TukTuk.Checked)
            {
                vehical = 1;
            }
            else if (RadioButton_car.Checked)
            {
                vehical = 2;
            }
            else if (RadioButton_van.Checked)
            {
                vehical = 3;
            }

            if (nullselectTextBox == 0)
            {
                SQL sql = new SQL();
                bool taxiDataInserted = sql.InsertTaxiData(pickup,  drop, date, Email, vehical );

                if (taxiDataInserted)
                {
                    MessageBox.Show("Taxi data submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to submit taxi data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                for(int i=0; i<textBoxes.Length; i++)
                {
                    if (textBoxes[i].Text == string.Empty)
                    {
                        labls[i].Text = "Please Fill Details";
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            
        }

        private void TextBox_Pickup_Enter(object sender, EventArgs e)
        {
            Label_PError.Text = string.Empty;           
        }

        private void TextBox_Drop_Enter(object sender, EventArgs e)
        {
            Label_DError.Text = string.Empty;
        }
    }
}

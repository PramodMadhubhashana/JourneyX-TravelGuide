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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Label_Province_Click(object sender, EventArgs e)
        {

        }
        private void Button_Taxi_Click(object sender, EventArgs e)
        {
            Taxi taxi = Application.OpenForms.OfType<Taxi>().FirstOrDefault();
            if(taxi != null)
            {
                taxi.Activate();
            }
            else
            {
                taxi = new Taxi();
                taxi.Show();
            }
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            Guna2ComboBox[] comboBoxes = { ComboBox_Province, ComboBox_Place };
            Guna2HtmlLabel[] labels = { Label_proviceError, Label_PlaceError };
            int nullCombobox = comboBoxes.Count(cb => cb.SelectedIndex == 0);
           

            if(nullCombobox == 0)
            {

            }
            else
            {
                for (int i =0;i<comboBoxes.Length; i++)
                {
                    if (comboBoxes[i].SelectedIndex == 0)
                    {
                        labels[i].Text = "Please Fill The Details";
                    }
                    else
                    {
                        continue;
                    }                    
                }
            }
        }
        private void Schedule_Load(object sender, EventArgs e)
        {
            ComboBox_Place.SelectedIndex = 0;
            ComboBox_Province.SelectedIndex = 0;
        }

        private void ComboBox_Province_Click(object sender, EventArgs e)
        {
            Label_proviceError.Text = string.Empty;
        }

        private void ComboBox_Place_Click(object sender, EventArgs e)
        {
            Label_PlaceError.Text = string.Empty;
        }
    }
}

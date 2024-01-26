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
    public partial class Feedback : Form
    {
        public string Email;
        public Feedback(string email)
        {
            InitializeComponent();
            Email = email;
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Feedback_Load(object sender, EventArgs e)
        {

        }
        bool Excellent = false, Good = false, Medium = false , Poor = false , VeryBad = false ;

        private void Button_verybad_Click(object sender, EventArgs e)
        {
            if (VeryBad == false)
            {
                Button_verybad.Image = Properties.Resources.angry_color;
                VeryBad = true;
            }
            else
            {
                Button_verybad.Image = Properties.Resources.angry;
                VeryBad = false;
            }
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            String comment = TextBox_feedback.Text.ToString();

            SQL sql = new SQL();
           bool feedbackInserted = sql.InsertFeedback(comment, Email);
            if (feedbackInserted)
            {
                MessageBox.Show("Feedback submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to submit feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void Button_medium_Click(object sender, EventArgs e)
        {
            if (Medium == false)
            {
                Button_medium.Image = Properties.Resources.neutral_color;
                Medium = true;
            }
            else
            {
                Button_medium.Image = Properties.Resources.neutral;
                Medium = false;
            }

        }

        private void Button_Good_Click(object sender, EventArgs e)
        {
            if (Good == false)
            {
                Button_Good.Image = Properties.Resources.smile_color;
                Good = true;
            }
            else
            {
                Button_Good.Image = Properties.Resources.smile;
                Good = false;
            }
        }

        private void Button_Ecellent_Click(object sender, EventArgs e)
        {
            if(Excellent == false)
            {
                Button_Ecellent.Image = Properties.Resources.happy_color;
                Excellent = true;
            }
            else
            {
                Button_Ecellent.Image = Properties.Resources.happy; 
                Excellent = false;
            }
        }
    }
}

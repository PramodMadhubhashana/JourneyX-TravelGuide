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
        public Feedback()
        {
            InitializeComponent();
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
                Button_verybad.Image = Image.FromFile("Icons\\angry color.png");
                VeryBad = true;
            }
            else
            {
                Button_verybad.Image = Image.FromFile("Icons\\angry.png");
                VeryBad = false;
            }
        }

        private void Button_poor_Click(object sender, EventArgs e)
        {
            if (Poor == false)
            {
                Button_poor.Image = Image.FromFile("Icons\\sad color.png");
                Poor = true;
            }
            else
            {
                Button_poor.Image = Image.FromFile("Icons\\sad-face.png");
                Poor = false;
            }
        }

        private void Button_medium_Click(object sender, EventArgs e)
        {
            if (Medium == false)
            {
                Button_medium.Image = Image.FromFile("Icons\\neutral color.png");
                Medium = true;
            }
            else
            {
                Button_medium.Image = Image.FromFile("Icons\\neutral.png");
                Medium = false;
            }

        }

        private void Button_Good_Click(object sender, EventArgs e)
        {
            if (Good == false)
            {
                Button_Good.Image = Image.FromFile("Icons\\smile color.png");
                Good = true;
            }
            else
            {
                Button_Good.Image = Image.FromFile("Icons\\smile.png");
                Good = false;
            }
        }

        private void Button_Ecellent_Click(object sender, EventArgs e)
        {
            if(Excellent == false)
            {
                Button_Ecellent.Image = Image.FromFile("Icons\\happy color.png");
                Excellent = true;
            }
            else
            {
                Button_Ecellent.Image = Image.FromFile("Icons\\happy.png");
                Excellent = false;
            }
        }
    }
}

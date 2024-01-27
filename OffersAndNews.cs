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
    public partial class OffersAndNews : Form
    {
        public OffersAndNews()
        {
            InitializeComponent();
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            //pramod
        }     

        private void OffersAndNews_Load(object sender, EventArgs e)
        {
            SQL sQL = new SQL();            

            string firstThreeOffersDetails = sQL.GetFirstThreeOffersDetails();

            if (!firstThreeOffersDetails.Equals("--Error--") && !firstThreeOffersDetails.Equals("--No Data--"))
            {
                string[] offerComponents = firstThreeOffersDetails.Split('+');
                int a = offerComponents.Length;

                if (a < 3)
                {
                    panel1.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel4.Visible = false;
                    Label1offer.Text = offerComponents[1];
                    Label1Date.Text = offerComponents[2];
                }
                else if (a < 5)
                {
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = false;
                    panel4.Visible = false;
                    Label1offer.Text = offerComponents[1];
                    Label1Date.Text = offerComponents[2];
                    Label2Offers.Text = offerComponents[3];
                    Label2Date.Text = offerComponents[4];
                }
                else if (a < 5)
                {
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = false;
                    Label1offer.Text = offerComponents[1];
                    Label1Date.Text = offerComponents[2];
                    Label2Offers.Text = offerComponents[3];
                    Label2Date.Text = offerComponents[4];
                    Label3Offers.Text = offerComponents[5];
                    Label3Date.Text = offerComponents[6];
                }
                else
                {
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = true;
                    Label1offer.Text = offerComponents[1];
                    Label1Date.Text = offerComponents[2];
                    Label2Offers.Text = offerComponents[3];
                    Label2Date.Text = offerComponents[4];
                    Label3Offers.Text = offerComponents[5];
                    Label3Date.Text = offerComponents[6];
                    Label4Offers.Text = offerComponents[7];
                    Label4Date.Text = offerComponents[8];
                }

            }
            else
            {
                MessageBox.Show("An error has occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

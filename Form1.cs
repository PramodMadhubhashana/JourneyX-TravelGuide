using Guna.UI2;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JourneyX
{
    public partial class Form_JourneyX : Form
    {
        public Form_JourneyX()
        {
            InitializeComponent();
            GradientPanel_CreateAccount1st.Location = new System.Drawing.Point(0, 0);
            GradientPanel_CreateAccount2nd.Location = new System.Drawing.Point(0, 0);
            GradientPanel_CreateAccount1st.Width = 0;
            GradientPanel_CreateAccount2nd.Width = 0;
            ProgressBar_Weak.Hide();
            ProgressBar_Short.Hide();            
            ProgressBar_Good.Hide();
            ProgressBar_Strong.Hide();
            Label_Weak.Hide();
            Label_Short.Hide();
            Label_Good.Hide();
            Label_Strong.Hide();
            ProgressIndicator_CreateAccount.Hide();
            ProgressIndicator_Login.Hide(); 
        }
        private bool CreateAccount1stPage = false;
        private bool CreateAccount2ndPage = false;
        private bool PopularPlace = true;
        private bool CA1stPageExit = false;
        private bool CA2stPageExit = false;

        private void timer_SidePanel_Tick(object sender, EventArgs e)
        {
            if (PopularPlace == true)
            {
                GradientPanel_PopularPlace.Width -= 100;
                GradientPanel_CreateAccount1st.Width += 100;

                if (GradientPanel_CreateAccount1st.Width == GradientPanel_CreateAccount1st.MaximumSize.Width)
                {
                    CreateAccount1stPage = true;
                    PopularPlace = false;
                    Button_SignUp.Enabled = false;
                    timer_SidePanel.Stop();
                }
            }
            else if (PopularPlace == false)
            {
                if (CreateAccount1stPage == true && CA1stPageExit == false)
                {
                    GradientPanel_CreateAccount1st.Width -= 100;
                    GradientPanel_CreateAccount2nd.Width += 100;

                    if (GradientPanel_CreateAccount2nd.Width == GradientPanel_CreateAccount2nd.MaximumSize.Width)
                    {
                        CreateAccount1stPage = false;
                        CreateAccount2ndPage = true;
                        timer_SidePanel.Stop();
                    }
                }
                else if (CA1stPageExit == true)
                {
                    GradientPanel_CreateAccount1st.Width -= 100;
                    GradientPanel_PopularPlace.Width += 100;

                    if (GradientPanel_PopularPlace.Width == GradientPanel_PopularPlace.MaximumSize.Width)
                    {
                        CreateAccount1stPage = false;
                        CA1stPageExit = false;
                        PopularPlace = true;
                        Button_SignUp.Enabled = true;
                        timer_SidePanel.Stop();
                    }
                }
                else if (CA2stPageExit == true)
                {
                    GradientPanel_CreateAccount2nd.Width -= 100;
                    GradientPanel_PopularPlace.Width += 100;

                    if (GradientPanel_PopularPlace.Width == GradientPanel_PopularPlace.MaximumSize.Width)
                    {
                        CreateAccount2ndPage = false;
                        CA2stPageExit = false;
                        PopularPlace = true;
                        Button_SignUp.Enabled = true;
                        timer_SidePanel.Stop();
                    }
                }
                else if(CreateAccount2ndPage == true)
                {
                    GradientPanel_CreateAccount2nd.Width -= 100;
                    GradientPanel_PopularPlace.Width += 100;

                    if (GradientPanel_PopularPlace.Width == GradientPanel_PopularPlace.MaximumSize.Width)
                    {
                        CreateAccount2ndPage = false;                        
                        PopularPlace = true;
                        Button_SignUp.Enabled = true;
                        timer_SidePanel.Stop();
                    }
                }
            }
        }
        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            timer_SidePanel.Start();
        }
        private void GradientButton_Next_Click(object sender, EventArgs e)
        {
            Guna2TextBox[] CA1stPagetextBoxes = { TextBox_FirstName, TextBox_LastName, TextBox_Address };
            Guna2HtmlLabel[] CA1stPagelabelsCA1stPage = { Label_FirstNameError, Label_LastNameError, Label_AddressError };

            int null1stPageTextboxCount = CA1stPagetextBoxes.Count(tb => string.IsNullOrEmpty(tb.Text));           

            if(null1stPageTextboxCount == 0)
            {
                if ((DateTime.Now.Year - DateTimePicker_BirthDay.Value.Year) >= 10 && (!RadioButton_Male.Checked || !RadioButton_Female.Checked))
                {
                    timer_SidePanel.Start();
                    CreateAccount2ndPage = true;
                    ProgressBar_1stPage.Value = 55;
                    ProgressBar_2ndPage.Value = 55;
                }               
                else if ((DateTime.Now.Year - DateTimePicker_BirthDay.Value.Year) < 10 && (RadioButton_Male.Checked == false && RadioButton_Female.Checked == false))
                {
                    Label_BirthDayError.Text = "Can't Create Account Under 10 Years old...";
                    Label_GenderError.Text = "Please Select Your Gender.";

                    if ((DateTime.Now.Year - DateTimePicker_BirthDay.Value.Year) >= 10)
                    {
                        Label_BirthDayError.Text = "Can't Create Account Under 10 Years old...";
                    }
                    else if (RadioButton_Male.Checked == false && RadioButton_Female.Checked == false)
                    {
                        Label_GenderError.Text = "Please Select Your Gender.";
                    }
                }
            }
            else
            {
                for(int i=0; i < CA1stPagetextBoxes.Length; i++)
                {
                    if (CA1stPagetextBoxes[i].Text == string.Empty)
                    {
                        CA1stPagelabelsCA1stPage[i].Text = "Please Fill The Details...";
                    }
                }
                if ((RadioButton_Male.Checked == false && RadioButton_Female.Checked == false) && (DateTime.Now.Year - DateTimePicker_BirthDay.Value.Year) < 10)
                {
                    Label_GenderError.Text = "Please Select Your Gender.";
                    Label_BirthDayError.Text = "Please Select Your BirthDay";

                    if (DateTime.Now.Date == DateTimePicker_BirthDay.Value.Date)
                    {
                        Label_BirthDayError.Text = "Please Select Your BirthDay";
                    }
                    else if(RadioButton_Male.Checked == false && RadioButton_Female.Checked == false)
                    {
                        Label_GenderError.Text = "Please Select Your Gender.";
                    }
                }  
            }
        }
        private void Button_CA1stPageExit_Click(object sender, EventArgs e)
        {
            CA1stPageExit = true;
            timer_SidePanel.Start(); 
        }
        private void Button_CA2ndPageExit_Click(object sender, EventArgs e)
        {
            CA2stPageExit = true;
            timer_SidePanel.Start();           
        }
        private void TextBox_FirstName_Enter(object sender, EventArgs e)
        {
            Label_FirstNameError.Text = string.Empty;
        }
        private void TextBox_LastName_Enter(object sender, EventArgs e)
        {
            Label_LastNameError.Text = string.Empty;
        }
        private void TextBox_Address_Enter(object sender, EventArgs e)
        {
            Label_AddressError.Text = string.Empty;
        }       
        private void RadioButton_Male_Enter(object sender, EventArgs e)
        {
            Label_GenderError.Text = string.Empty;
        }
        private void RadioButton_Female_Enter(object sender, EventArgs e)
        {
            Label_GenderError.Text = string.Empty;
        }
        private void DateTimePicker_BirthDay_Click(object sender, EventArgs e)
        {
            Label_BirthDayError.Text = string.Empty;
        }        
        private void Button_CreateAccount_Click(object sender, EventArgs e)
        {
            string FirstName = TextBox_FirstName.Text.ToString();
            string LastName = TextBox_LastName.Text.ToString();
            string Address = TextBox_Address.Text.ToString();
            DateTime Birthday = DateTimePicker_BirthDay.Value;
            string Email = TextBox_Email.Text.ToString();
            string PhoneNumber = TextBox_PhoneNumber.Text.ToString();
            string Password = TextBox_Password.Text.ToString();

            Guna2TextBox[] CA2ndPagetextBoxes = { TextBox_Email, TextBox_PhoneNumber, TextBox_Password, TextBox_ConfirmPassword };
            Guna2HtmlLabel[] CA2ndLabeles = { Label_EmailError, Label_PhoneNubmberError, Label_PasswordError, Label_CPasswordError };

            int null2ndPageTextBoxCount = CA2ndPagetextBoxes.Count(TB => string.IsNullOrEmpty(TB.Text));
            string Date = DateTimePicker_BirthDay.Value.ToString();
             
            if(null2ndPageTextBoxCount == 0)
            {
                if( TextBox_Password.Text.Length >= 8 )
                {
                    if (TextBox_Password.Text != TextBox_ConfirmPassword.Text)
                    {
                        Label_SPasswordError.Text = "Password does not match.";
                    }
                    else
                    {
                        timer_ProgressBar.Start();
                        SQL sql = new SQL();
                        if (RadioButton_Female.Checked == true)
                        {                            
                            string Error =  sql.ProfileDetails(FirstName, LastName, Address, Birthday, 0, Email, PhoneNumber, Password);
                            MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (RadioButton_Male.Checked == true)
                        {
                            string Error = sql.ProfileDetails(FirstName, LastName, Address, Birthday, 1, Email, PhoneNumber, Password);
                            MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    Label_PasswordError.Text = "Enter 8 more Characters.";
                }                
            }
            else
            {
                for(int i=0; i< CA2ndPagetextBoxes.Length; i++)
                {
                    if (CA2ndPagetextBoxes[i].Text == string.Empty)
                    {
                        CA2ndLabeles[i].Text = "Please Fill The Details.";
                    }
                }
            }
        }
        private void TextBox_Email_Enter(object sender, EventArgs e)
        {
            Label_EmailError.Text = string.Empty;
        }
        private void TextBox_PhoneNumber_Enter(object sender, EventArgs e)
        {
            Label_PhoneNubmberError.Text = string.Empty;
        }
        private void TextBox_Password_Enter(object sender, EventArgs e)
        {
            Label_PasswordError.Text = string.Empty;
            Label_SPasswordError.Text = string.Empty;
        }
        private void TextBox_ConfirmPassword_Enter(object sender, EventArgs e)
        {
            Label_CPasswordError.Text = string.Empty;
            Label_SPasswordError.Text = string.Empty;
        }
        private void Button_Login_Click(object sender, EventArgs e)
        {
           
            string Email = TextBox_LoginUserName.ToString();
            string Password = TextBox_LoginPassword.ToString();
            Guna2TextBox[] LtextBoxes = {TextBox_LoginUserName, TextBox_LoginPassword};
            Guna2HtmlLabel[] Llabels = { Label_LUNError, Label_LPError };

            int null1stPageTextboxCount = LtextBoxes.Count(tb => string.IsNullOrEmpty(tb.Text));

     

           if (null1stPageTextboxCount == 0)
            {
                timer_login.Start();
                SQL sQL = new SQL();
                string A = sQL.Login(Email, Password);
              
                if(Email == "AA0000")
                {
                    Form1 form = new Form1();
                    form.Close();
                    DashBoard dashBoard = new DashBoard(Email);
                    dashBoard.Show();                 
                    
                }
                else if( A == "ADMIN3550")
                {

                }
                else
                {
                    Label_LoginError.Text = "Email or Password wrong Please check again.";
                }
            }
            else
            {
                for (int i = 0; i < LtextBoxes.Length; i++)
                {
                    if (LtextBoxes[i].Text == string.Empty)
                    {
                        Llabels[i].Text = "Please Fill Details..";
                    }
                }
            }
        }
            private void TextBox_LoginUserName_Enter(object sender, EventArgs e)
        {
            Label_LUNError.Text = string.Empty;
        }
        private void TextBox_LoginPassword_Enter(object sender, EventArgs e)
        {
            Label_LPError.Text = string.Empty;
        }       
        private void Button_LPHiden_Click(object sender, EventArgs e)
        {
            if(TextBox_LoginPassword.UseSystemPasswordChar == true)
            {
                TextBox_LoginPassword.UseSystemPasswordChar = false;
                Button_LPHiden.Image = Image.FromFile("Icons\\eye.png");
            }
            else
            {
                TextBox_LoginPassword.UseSystemPasswordChar = true;
                Button_LPHiden.Image = Image.FromFile("Icons\\hidden.png");
            }
        }
        private void Button_SHiddenPassword_Click(object sender, EventArgs e)
        {
            if (TextBox_Password.UseSystemPasswordChar == true)
            {
                TextBox_Password.UseSystemPasswordChar = false;
                Button_LPHiden.Image = Image.FromFile("Icons\\eye.png");
            }
            else
            {
                TextBox_Password.UseSystemPasswordChar = true;
                Button_LPHiden.Image = Image.FromFile("Icons\\hidden.png");
            }
        }
        private void Button_SCHidden_Click(object sender, EventArgs e)
        {
            if (TextBox_ConfirmPassword.UseSystemPasswordChar == true)
            {
                TextBox_ConfirmPassword.UseSystemPasswordChar = false;
                Button_LPHiden.Image = Image.FromFile("Icons\\eye.png");
            }
            else
            {
                TextBox_ConfirmPassword.UseSystemPasswordChar = true;
                Button_LPHiden.Image = Image.FromFile("Icons\\hidden.png");
            }
        } 
        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            if(TextBox_Password.Text.Length < 4)
            {
                ProgressBar_Weak.Show();
                Label_Weak.Show();
            }
            else if(TextBox_Password.Text.Length < 8)
            {
                ProgressBar_Weak.Show();
                ProgressBar_Short.Show();
                Label_Short.Show();
                Label_Short.Show();
            }       
            else if(TextBox_Password.Text.Length < 12)
            {
                ProgressBar_Weak.Show();
                ProgressBar_Short.Show();
                ProgressBar_Good.Show();
                Label_Weak.Show();
                Label_Short.Show();
                Label_Good.Show();
            }
            else
            {
                ProgressBar_Weak.Show();
                ProgressBar_Short.Show();
                ProgressBar_Good.Show();
                ProgressBar_Strong.Show();
                Label_Weak.Show();
                Label_Short.Show();
                Label_Good.Show();
                Label_Strong.Show();
            }      
        }
        private int secound = 0;
        private void timer_ProgressBar_Tick(object sender, EventArgs e)
        {
            secound++;
            ProgressIndicator_CreateAccount.Start();
            ProgressIndicator_CreateAccount.Show();
            if (secound > 5)
            {
                ProgressIndicator_CreateAccount.Stop();
                timer_ProgressBar.Stop();
                MessageBox.Show("Create Account  succsesfull...", "succsesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                secound = 0;
                timer_SidePanel.Start();
            }       
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Close();
            DashBoard dashBoard = new DashBoard("pramod");
            dashBoard.Show();   



           // this.WindowState = FormWindowState.Minimized;
        } 
        private void timer_PictureBox_Tick(object sender, EventArgs e)
        {
            Image[] images = {  Image.FromFile("Pictures\\1.jpg"),
                                Image.FromFile("Pictures\\2.jpg"),
                                Image.FromFile("Pictures\\3.jpg"),
                                Image.FromFile("Pictures\\4.jpg"),
                                Image.FromFile("Pictures\\5.jpg"),
                                Image.FromFile("Pictures\\6.jpg"),
                                Image.FromFile("Pictures\\7.jpg"),
                                Image.FromFile("Pictures\\8.jpg"),
                                Image.FromFile("Pictures\\9.jpg"),
                                Image.FromFile("Pictures\\10.jpg")
                           };
            imageindex++; 
            if(imageindex >= images.Length)
            {
                imageindex = 0;
            }
            PictureBox_LoginPage.Image = images[imageindex];  
        }
        private int imageindex = 0;
        private void Form_JourneyX_Load(object sender, EventArgs e)
        {
            timer_PictureBox.Start();
        }
        private void timer_login_Tick(object sender, EventArgs e)
        {
            secound++;
            ProgressIndicator_Login.Start();
            ProgressIndicator_Login.Show();
            if (secound > 10)
            {
               ProgressIndicator_Login.Stop();
                timer_login.Stop();
                secound = 0;               
            }
        }
        private void Google_Map(String Location)
        {
            GoogleMap googleMap = new GoogleMap(Location);
            googleMap.Show();           
        }
        private void Button_Sigiriya_Click(object sender, EventArgs e)
        {
            Google_Map("https://www.google.com/maps/place/Sigiriya/@7.9546778,80.7267257,14z/data=!4m10!1m2!2m1!1ssigiriya!3m6!1s0x3afca15b724c9ab3:0xab1771275b370d52!8m2!3d7.9570327!4d80.760257!15sCghzaWdpcml5YZIBEnRvdXJpc3RfYXR0cmFjdGlvbuABAA!16zL20vMDRnX2tr");
        }
        private void Button_GalleFrt_Click(object sender, EventArgs e)
        {
            Google_Map("https://www.google.com/maps/place/Fort,+Galle+80000/@6.0272723,80.2123323,16z/data=!3m1!4b1!4m5!3m4!1s0x3ae173a6a024d64d:0x569ac10c90e0fa7c!8m2!3d6.0266778!4d80.2174914"); ;
        }
        private void Button_JungleBeach_Click(object sender, EventArgs e)
        {
            Google_Map("https://www.google.com/maps/place/Jungle+Beach,+Unawatuna./@6.0187413,80.237241,17z/data=!3m1!4b1!4m5!3m4!1s0x3ae172f91480ca31:0x79f7cdf47fbff48b!8m2!3d6.0187413!4d80.2394297");
        }
        private void Button_NuwaraEliya_Click(object sender, EventArgs e)
        {
            Google_Map("https://www.google.com/maps/place/Nuwara+Eliya/@6.9513649,80.7459271,13z/data=!3m1!4b1!4m5!3m4!1s0x3ae380434e1554c7:0x291608404c937d9c!8m2!3d6.9497166!4d80.7891068");
        }
        private void Button_NelligalaTemple_Click(object sender, EventArgs e)
        {
            Google_Map("https://www.google.com/maps/place/nelligala+temple/@7.2905989,80.1063331,10z/data=!4m10!1m2!2m1!1snelligala+temple!3m6!1s0x3ae367f3bc9b0fbd:0x49071a392d33c66d!8m2!3d7.2906053!4d80.6336651!15sChBuZWxsaWdhbGEgdGVtcGxlkgEPYnVkZGhpc3RfdGVtcGxl4AEA!16s%2Fg%2F11k50cr8x2");
        }

        private void Label_Sigiriya_Click(object sender, EventArgs e)
        {

        }
    }
}

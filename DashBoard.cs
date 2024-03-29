﻿using Guna.UI2;
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
    public partial class DashBoard : Form
    {
        public string Email;  
        
        public DashBoard(string email)
        {            
            InitializeComponent();
            Email= email;            
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            PictureBox_News.Image = Properties.Resources.explore_exploit_tradeoff1;
            try
            {
                SQL sQL = new SQL();
                string Name = sQL.Dashboard(Email);
                string[] dataParts = Name.Split('+');
                Console.WriteLine(dataParts[0]);
                Console.WriteLine(dataParts[1]);

                if (Name == "--Error--" )
                {                    
                    MessageBox.Show("An error has occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                    
                }
                else
                {
                    Label_HName.Text = dataParts[0];
                    Label_Name.Text = dataParts[0];
                    string[] placesAndDates = sQL.MySchedule(Email);
                    List<string[]> partsList = new List<string[]>();
                    int a = Int32.Parse(dataParts[1]);
                    
                    switch (a)
                    {
                        case 1:
                            Profilepicture.Image = Properties.Resources.Picture011;
                            break;

                        case 2:
                            Profilepicture.Image = Properties.Resources.Picture021;
                            break;

                        case 3:
                            Profilepicture.Image = Properties.Resources.Picture031;
                            break;

                        case 4:
                            Profilepicture.Image = Properties.Resources.Picture041;
                            break;

                        case 5:
                            Profilepicture.Image = Properties.Resources.Picture051;
                            break;

                        case 6:
                            Profilepicture.Image = Properties.Resources.Picture061;
                            break;
                    }


                    if (placesAndDates[0] == "--No Data--")
                    {
                        panelmain.Visible = false;
                    }
                    else if (placesAndDates[1] == "--No Data--")
                    {
                        panelmain.Visible = true;
                        Panel_M1.Visible = true;
                        Panel_M2.Visible = false;
                        Panel_M3.Visible = false;
                    }
                    else if (placesAndDates[3] == "--No Data--")
                    {
                        panelmain.Visible = true;
                        Panel_M1.Visible = true;
                        Panel_M2.Visible = true;
                        Panel_M3.Visible = true;
                    }

                    try
                    {
                        foreach (string combinedString in placesAndDates)
                        {
                            if (string.IsNullOrWhiteSpace(combinedString))
                            {
                                break;
                            }

                            string[] parts = combinedString.Split(new[] { " - " }, StringSplitOptions.None);
                            partsList.Add(parts);
                        }

                        // Access parts from the list based on your requirements
                        if (partsList.Count > 0)
                        {
                            Label_ML1.Text = partsList[0][0];
                            Label_MD1.Text = partsList[0][1];
                            Label_ML2.Text = partsList[1][0];
                            Label_MD2.Text = partsList[1][1];
                            Label_ML3.Text = partsList[2][0];
                            Label_MD3.Text = partsList[2][1];
                            Console.WriteLine(partsList[0][0]);
                            Console.WriteLine(partsList[0][1]);
                            // Access additional parts as needed
                        }
                    }
                    catch (Exception)
                    {
                        return;
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void Button_Feedback_Click(object sender, EventArgs e)
        {
            Feedback feedback = Application.OpenForms.OfType<Feedback>().FirstOrDefault();
            if(feedback != null)
            {
                feedback.Activate();
            }
            else
            {
                feedback = new Feedback(Email);
                feedback.Show();
            }   
        }
        private void Button_Logout_Click(object sender, EventArgs e)
        {
            Form_JourneyX login = new Form_JourneyX();
            login.Show();
            DashBoard dashBoard = new DashBoard(Email);
            dashBoard.Close();            
        }        
        private void Button1_star_Click(object sender, EventArgs e)
        {
            
        }
        private void Google_Map(String Location)
        {
            GoogleMap googleMap = new GoogleMap(Location);
            googleMap.Show();
        }
        private void Button1_PLocation_Click(object sender, EventArgs e)
        {
            Google_Map("https://www.google.com/maps/place/Fort,+Galle+80000/@6.0272723,80.2123323,16z/data=!3m1!4b1!4m5!3m4!1s0x3ae173a6a024d64d:0x569ac10c90e0fa7c!8m2!3d6.0266778!4d80.2174914");
        }
        private void Button2_PLocation_Click(object sender, EventArgs e)
        {
            Google_Map("https://www.google.com/maps/place/Hikkaduwa+Beach/@6.1346985,80.0975761,17z/data=!3m1!4b1!4m6!3m5!1s0x3ae177e2cbcb6ead:0xd0adba737d2f45d9!8m2!3d6.1377266!4d80.0990596!16s%2Fg%2F1tgllb4n");
        }
        private void Button3_PLocation_Click(object sender, EventArgs e)
        {
            Google_Map("https://www.google.com/maps/place/Nuwara+Eliya/@6.9513649,80.7459271,13z/data=!3m1!4b1!4m5!3m4!1s0x3ae380434e1554c7:0x291608404c937d9c!8m2!3d6.9497166!4d80.7891068");
        }
        private void Button_Edit_Click(object sender, EventArgs e)
        {
            Profile profile = Application.OpenForms.OfType<Profile>().FirstOrDefault();
            if(profile != null)
            {
                profile.Activate();
            }
            else
            {
                profile = new Profile(Email);
                profile.Show();
            }
        }
        private void Button_notification_Click(object sender, EventArgs e)
        {
            Notification notification = Application.OpenForms.OfType<Notification>().FirstOrDefault();
            if(notification != null)
            {
                notification.Activate();
            }
            else
            {
                notification = new Notification();
                notification.Show();
                notification.Location = new Point(685,84);
            }            
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button_OffersAndNews_Click(object sender, EventArgs e)
        {
            OffersAndNews offersAndNews = Application.OpenForms.OfType<OffersAndNews>().FirstOrDefault();
            if(offersAndNews != null)
            {
                offersAndNews.Activate();
            }
            else
            {
                offersAndNews = new OffersAndNews();
                offersAndNews.Show();
            }
        }        
        private void Button_Schedule_Click(object sender, EventArgs e)
        {
            Schedule schedule = Application.OpenForms.OfType<Schedule>().FirstOrDefault();
            if(schedule != null)
            {
                schedule.Activate();
            }
            else
            {
                schedule = new Schedule(Email);
                schedule.Show();
            }           
        }

        private void Button_OffersAndNews_Click_1(object sender, EventArgs e)
        {
            OffersAndNews offersAndNews = Application.OpenForms.OfType<OffersAndNews>().FirstOrDefault();
            if (offersAndNews != null)
            {
                offersAndNews.Activate();
            }
            else
            {
                offersAndNews = new OffersAndNews();
                offersAndNews.Show();
            }
        }

        private void Button_Dashboard_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = Application.OpenForms.OfType<DashBoard>().FirstOrDefault();
            if(dashBoard != null)
            {
                dashBoard.Activate();
            }
            else
            {
                dashBoard = new DashBoard(Email);
                dashBoard.Show();
            }
        }

        private void Button_Profile_Click(object sender, EventArgs e)
        {
            Profile profile = Application.OpenForms.OfType<Profile>().FirstOrDefault();
            if(profile != null)
            {
                profile.Activate();
            }
            else
            {
                profile = new Profile(Email);
                profile.Show();
            }
        }
        private void Button_Taxi_Click(object sender, EventArgs e)
        {
            Taxi taxi = Application.OpenForms.OfType<Taxi>().FirstOrDefault();
            if(taxi!= null)
            {
                taxi.Activate();
            }
            else
            {
                taxi = new Taxi(Email);
                taxi.Show();
            }
        }      

        private void Label_HName_Click(object sender, EventArgs e)
        {

        }

        private void timerload_Tick(object sender, EventArgs e)
        {
            timerload.Start();
            DashBoard_Load(sender, e);
            Console.WriteLine("swssssss");
        }

        private void unwatuna(object sender, EventArgs e)
        {
            Google_Map(" https://www.google.com/maps?q=unawatuna+beach&gs_lcrp=EgZjaHJvbWUyDwgAEEUYORiDARixAxiABDIHCAEQABiABDIHCAIQABiABDIHCAMQABiABDIHCAQQABiABDIHCAUQABiABDIHCAYQABiABDIHCAcQABiABDIGCAgQRRhA0gEINTU3OWowajGoAgCwAgA&um=1&ie=UTF-8");
       
        }
    }
}

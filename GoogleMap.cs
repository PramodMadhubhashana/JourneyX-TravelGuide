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
    public partial class GoogleMap : Form
    {
        private String Lctn;
        public GoogleMap(String Location)
        {
            InitializeComponent();
            Lctn = Location;
            webBrowser_GoogleMap.ScriptErrorsSuppressed = true;            
        }
        private void GoogleMap_Load(object sender, EventArgs e)
        {
            StringBuilder location = new StringBuilder();
            location.Append(Lctn);            
            webBrowser_GoogleMap.Navigate(location.ToString()); 
            guna2WinProgressIndicator.Start();    
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Button_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                Button_Maximize.Image = Image.FromFile("Icons\\restore-down.png");
                Button_Maximize.Image = new Bitmap(Button_Maximize.Image, new Size(15, 15));
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Button_Maximize.Image = Image.FromFile("Icons\\maximize.png");
                Button_Maximize.Image = new Bitmap(Button_Maximize.Image, new Size(15, 15));
            }
           
        }
        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void webBrowser_GoogleMap_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            guna2WinProgressIndicator.Stop();
            guna2WinProgressIndicator.Visible = false;
        }

        private void guna2WinProgressIndicator_Click(object sender, EventArgs e)
        {

        }
    }
}

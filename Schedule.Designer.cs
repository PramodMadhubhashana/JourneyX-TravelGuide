namespace JourneyX
{
    partial class Schedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.BorderlessForm_Schedule = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Button_exit = new Guna.UI2.WinForms.Guna2Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Label_Province = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComboBox_Province = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Label_place = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComboBox_Place = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Label_dateandTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Taxi = new Guna.UI2.WinForms.Guna2Button();
            this.Label_proviceError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Label_PlaceError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessForm_Schedule
            // 
            this.BorderlessForm_Schedule.ContainerControl = this;
            this.BorderlessForm_Schedule.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm_Schedule.ResizeForm = false;
            this.BorderlessForm_Schedule.TransparentWhileDrag = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.Button_exit);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(29)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(29)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1565, 49);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // Button_exit
            // 
            this.Button_exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_exit.FillColor = System.Drawing.Color.Transparent;
            this.Button_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_exit.ForeColor = System.Drawing.Color.Transparent;
            this.Button_exit.Image = ((System.Drawing.Image)(resources.GetObject("Button_exit.Image")));
            this.Button_exit.ImageSize = new System.Drawing.Size(16, 16);
            this.Button_exit.Location = new System.Drawing.Point(1512, 6);
            this.Button_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(35, 32);
            this.Button_exit.TabIndex = 1;
            this.Button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(811, 287);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Label_Province
            // 
            this.Label_Province.BackColor = System.Drawing.Color.Transparent;
            this.Label_Province.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Province.ForeColor = System.Drawing.Color.White;
            this.Label_Province.Location = new System.Drawing.Point(385, 60);
            this.Label_Province.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Label_Province.Name = "Label_Province";
            this.Label_Province.Size = new System.Drawing.Size(168, 27);
            this.Label_Province.TabIndex = 3;
            this.Label_Province.Text = "Selct You Province";
            this.Label_Province.Click += new System.EventHandler(this.Label_Province_Click);
            // 
            // ComboBox_Province
            // 
            this.ComboBox_Province.AutoRoundedCorners = true;
            this.ComboBox_Province.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Province.BorderRadius = 17;
            this.ComboBox_Province.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Province.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ComboBox_Province.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Province.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Province.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_Province.ForeColor = System.Drawing.Color.White;
            this.ComboBox_Province.ItemHeight = 30;
            this.ComboBox_Province.Items.AddRange(new object[] {
            "--Select--",
            "Southern Province",
            "Western Province"});
            this.ComboBox_Province.Location = new System.Drawing.Point(587, 60);
            this.ComboBox_Province.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_Province.Name = "ComboBox_Province";
            this.ComboBox_Province.Size = new System.Drawing.Size(472, 36);
            this.ComboBox_Province.TabIndex = 5;
            this.ComboBox_Province.Click += new System.EventHandler(this.ComboBox_Province_Click);
            // 
            // Label_place
            // 
            this.Label_place.BackColor = System.Drawing.Color.Transparent;
            this.Label_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_place.ForeColor = System.Drawing.Color.White;
            this.Label_place.Location = new System.Drawing.Point(435, 160);
            this.Label_place.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Label_place.Name = "Label_place";
            this.Label_place.Size = new System.Drawing.Size(62, 27);
            this.Label_place.TabIndex = 3;
            this.Label_place.Text = "Places";
            this.Label_place.Click += new System.EventHandler(this.Label_Province_Click);
            // 
            // ComboBox_Place
            // 
            this.ComboBox_Place.AutoRoundedCorners = true;
            this.ComboBox_Place.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Place.BorderRadius = 17;
            this.ComboBox_Place.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Place.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Place.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ComboBox_Place.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Place.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Place.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_Place.ForeColor = System.Drawing.Color.White;
            this.ComboBox_Place.ItemHeight = 30;
            this.ComboBox_Place.Items.AddRange(new object[] {
            "--Select--",
            "Hikkaduwa",
            "Unawatuna"});
            this.ComboBox_Place.Location = new System.Drawing.Point(587, 160);
            this.ComboBox_Place.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_Place.Name = "ComboBox_Place";
            this.ComboBox_Place.Size = new System.Drawing.Size(472, 36);
            this.ComboBox_Place.TabIndex = 5;
            this.ComboBox_Place.Click += new System.EventHandler(this.ComboBox_Place_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(587, 247);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(472, 22);
            this.dateTimePicker.TabIndex = 6;
            // 
            // Label_dateandTime
            // 
            this.Label_dateandTime.BackColor = System.Drawing.Color.Transparent;
            this.Label_dateandTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_dateandTime.ForeColor = System.Drawing.Color.White;
            this.Label_dateandTime.Location = new System.Drawing.Point(435, 245);
            this.Label_dateandTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Label_dateandTime.Name = "Label_dateandTime";
            this.Label_dateandTime.Size = new System.Drawing.Size(44, 27);
            this.Label_dateandTime.TabIndex = 3;
            this.Label_dateandTime.Text = "Date";
            this.Label_dateandTime.Click += new System.EventHandler(this.Label_Province_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.BorderRadius = 10;
            this.Button_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(29)))));
            this.Button_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.ForeColor = System.Drawing.Color.White;
            this.Button_Add.Location = new System.Drawing.Point(607, 332);
            this.Button_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(159, 52);
            this.Button_Add.TabIndex = 7;
            this.Button_Add.Text = "Add";
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Taxi
            // 
            this.Button_Taxi.Animated = true;
            this.Button_Taxi.BorderRadius = 10;
            this.Button_Taxi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Taxi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Taxi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Taxi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Taxi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(29)))));
            this.Button_Taxi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Taxi.ForeColor = System.Drawing.Color.White;
            this.Button_Taxi.Location = new System.Drawing.Point(420, 332);
            this.Button_Taxi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Taxi.Name = "Button_Taxi";
            this.Button_Taxi.Size = new System.Drawing.Size(159, 52);
            this.Button_Taxi.TabIndex = 7;
            this.Button_Taxi.Text = "Book Taxi";
            this.Button_Taxi.Click += new System.EventHandler(this.Button_Taxi_Click);
            // 
            // Label_proviceError
            // 
            this.Label_proviceError.BackColor = System.Drawing.Color.Transparent;
            this.Label_proviceError.ForeColor = System.Drawing.Color.Red;
            this.Label_proviceError.Location = new System.Drawing.Point(721, 112);
            this.Label_proviceError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Label_proviceError.Name = "Label_proviceError";
            this.Label_proviceError.Size = new System.Drawing.Size(3, 2);
            this.Label_proviceError.TabIndex = 8;
            this.Label_proviceError.Text = null;
            // 
            // Label_PlaceError
            // 
            this.Label_PlaceError.BackColor = System.Drawing.Color.Transparent;
            this.Label_PlaceError.ForeColor = System.Drawing.Color.Red;
            this.Label_PlaceError.Location = new System.Drawing.Point(721, 212);
            this.Label_PlaceError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Label_PlaceError.Name = "Label_PlaceError";
            this.Label_PlaceError.Size = new System.Drawing.Size(3, 2);
            this.Label_PlaceError.TabIndex = 8;
            this.Label_PlaceError.Text = null;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::JourneyX.Properties.Resources.geniva1;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(21, 66);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(335, 496);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 4;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1129, 160);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(420, 279);
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1565, 580);
            this.Controls.Add(this.Label_PlaceError);
            this.Controls.Add(this.Label_proviceError);
            this.Controls.Add(this.Button_Taxi);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.ComboBox_Place);
            this.Controls.Add(this.ComboBox_Province);
            this.Controls.Add(this.Label_dateandTime);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.Label_place);
            this.Controls.Add(this.Label_Province);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm_Schedule;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button Button_exit;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Province;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_Province;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Place;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_place;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_dateandTime;
        private Guna.UI2.WinForms.Guna2Button Button_Taxi;
        private Guna.UI2.WinForms.Guna2Button Button_Add;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_PlaceError;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_proviceError;
    }
}
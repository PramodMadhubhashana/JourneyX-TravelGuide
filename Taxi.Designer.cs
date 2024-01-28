namespace JourneyX
{
    partial class Taxi
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
            this.BorderlessForm_Taxi = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Button_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBox_van = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBox_car = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBox_Tuk = new Guna.UI2.WinForms.Guna2PictureBox();
            this.RadioButton_TukTuk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioButton_car = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioButton_van = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Label_Pickup = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBox_Pickup = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label_Drop = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBox_Drop = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label_date = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Button_Book = new Guna.UI2.WinForms.Guna2Button();
            this.Label_BookVehicle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Label_PError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Label_DError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_van)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Tuk)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessForm_Taxi
            // 
            this.BorderlessForm_Taxi.ContainerControl = this;
            this.BorderlessForm_Taxi.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm_Taxi.ResizeForm = false;
            this.BorderlessForm_Taxi.TransparentWhileDrag = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.Button_Exit);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(29)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(29)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(418, 40);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Exit.FillColor = System.Drawing.Color.Transparent;
            this.Button_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Exit.ForeColor = System.Drawing.Color.White;
            this.Button_Exit.Image = global::JourneyX.Properties.Resources.cancel;
            this.Button_Exit.ImageSize = new System.Drawing.Size(16, 16);
            this.Button_Exit.Location = new System.Drawing.Point(376, 3);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(26, 26);
            this.Button_Exit.TabIndex = 1;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // PictureBox_van
            // 
            this.PictureBox_van.ImageRotate = 0F;
            this.PictureBox_van.Location = new System.Drawing.Point(295, 109);
            this.PictureBox_van.Name = "PictureBox_van";
            this.PictureBox_van.Size = new System.Drawing.Size(54, 45);
            this.PictureBox_van.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_van.TabIndex = 2;
            this.PictureBox_van.TabStop = false;
            // 
            // PictureBox_car
            // 
            this.PictureBox_car.ImageRotate = 0F;
            this.PictureBox_car.Location = new System.Drawing.Point(175, 109);
            this.PictureBox_car.Name = "PictureBox_car";
            this.PictureBox_car.Size = new System.Drawing.Size(54, 45);
            this.PictureBox_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_car.TabIndex = 2;
            this.PictureBox_car.TabStop = false;
            // 
            // PictureBox_Tuk
            // 
            this.PictureBox_Tuk.Image = global::JourneyX.Properties.Resources.rickshaw;
            this.PictureBox_Tuk.ImageRotate = 0F;
            this.PictureBox_Tuk.Location = new System.Drawing.Point(55, 109);
            this.PictureBox_Tuk.Name = "PictureBox_Tuk";
            this.PictureBox_Tuk.Size = new System.Drawing.Size(54, 45);
            this.PictureBox_Tuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Tuk.TabIndex = 2;
            this.PictureBox_Tuk.TabStop = false;
            // 
            // RadioButton_TukTuk
            // 
            this.RadioButton_TukTuk.AutoSize = true;
            this.RadioButton_TukTuk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton_TukTuk.CheckedState.BorderThickness = 0;
            this.RadioButton_TukTuk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton_TukTuk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButton_TukTuk.CheckedState.InnerOffset = -4;
            this.RadioButton_TukTuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.RadioButton_TukTuk.ForeColor = System.Drawing.Color.White;
            this.RadioButton_TukTuk.Location = new System.Drawing.Point(55, 172);
            this.RadioButton_TukTuk.Name = "RadioButton_TukTuk";
            this.RadioButton_TukTuk.Size = new System.Drawing.Size(63, 17);
            this.RadioButton_TukTuk.TabIndex = 3;
            this.RadioButton_TukTuk.Text = "TukTuk";
            this.RadioButton_TukTuk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButton_TukTuk.UncheckedState.BorderThickness = 2;
            this.RadioButton_TukTuk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButton_TukTuk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // RadioButton_car
            // 
            this.RadioButton_car.AutoSize = true;
            this.RadioButton_car.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton_car.CheckedState.BorderThickness = 0;
            this.RadioButton_car.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton_car.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButton_car.CheckedState.InnerOffset = -4;
            this.RadioButton_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.RadioButton_car.ForeColor = System.Drawing.Color.White;
            this.RadioButton_car.Location = new System.Drawing.Point(188, 172);
            this.RadioButton_car.Name = "RadioButton_car";
            this.RadioButton_car.Size = new System.Drawing.Size(41, 17);
            this.RadioButton_car.TabIndex = 3;
            this.RadioButton_car.Text = "Car";
            this.RadioButton_car.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButton_car.UncheckedState.BorderThickness = 2;
            this.RadioButton_car.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButton_car.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // RadioButton_van
            // 
            this.RadioButton_van.AutoSize = true;
            this.RadioButton_van.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton_van.CheckedState.BorderThickness = 0;
            this.RadioButton_van.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton_van.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButton_van.CheckedState.InnerOffset = -4;
            this.RadioButton_van.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.RadioButton_van.ForeColor = System.Drawing.Color.White;
            this.RadioButton_van.Location = new System.Drawing.Point(304, 172);
            this.RadioButton_van.Name = "RadioButton_van";
            this.RadioButton_van.Size = new System.Drawing.Size(44, 17);
            this.RadioButton_van.TabIndex = 3;
            this.RadioButton_van.Text = "Van";
            this.RadioButton_van.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButton_van.UncheckedState.BorderThickness = 2;
            this.RadioButton_van.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButton_van.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // Label_Pickup
            // 
            this.Label_Pickup.BackColor = System.Drawing.Color.Transparent;
            this.Label_Pickup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Pickup.ForeColor = System.Drawing.Color.White;
            this.Label_Pickup.Location = new System.Drawing.Point(55, 262);
            this.Label_Pickup.Name = "Label_Pickup";
            this.Label_Pickup.Size = new System.Drawing.Size(47, 18);
            this.Label_Pickup.TabIndex = 4;
            this.Label_Pickup.Text = "PickUp";
            // 
            // TextBox_Pickup
            // 
            this.TextBox_Pickup.AutoRoundedCorners = true;
            this.TextBox_Pickup.BorderRadius = 17;
            this.TextBox_Pickup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Pickup.DefaultText = "";
            this.TextBox_Pickup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Pickup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Pickup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Pickup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Pickup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TextBox_Pickup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Pickup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Pickup.ForeColor = System.Drawing.Color.White;
            this.TextBox_Pickup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Pickup.Location = new System.Drawing.Point(139, 262);
            this.TextBox_Pickup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Pickup.Name = "TextBox_Pickup";
            this.TextBox_Pickup.PasswordChar = '\0';
            this.TextBox_Pickup.PlaceholderText = "";
            this.TextBox_Pickup.SelectedText = "";
            this.TextBox_Pickup.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Pickup.TabIndex = 5;
            this.TextBox_Pickup.Enter += new System.EventHandler(this.TextBox_Pickup_Enter);
            // 
            // Label_Drop
            // 
            this.Label_Drop.BackColor = System.Drawing.Color.Transparent;
            this.Label_Drop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Drop.ForeColor = System.Drawing.Color.White;
            this.Label_Drop.Location = new System.Drawing.Point(55, 337);
            this.Label_Drop.Name = "Label_Drop";
            this.Label_Drop.Size = new System.Drawing.Size(33, 18);
            this.Label_Drop.TabIndex = 4;
            this.Label_Drop.Text = "Drop";
            // 
            // TextBox_Drop
            // 
            this.TextBox_Drop.AutoRoundedCorners = true;
            this.TextBox_Drop.BorderRadius = 17;
            this.TextBox_Drop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Drop.DefaultText = "";
            this.TextBox_Drop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Drop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Drop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Drop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Drop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TextBox_Drop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Drop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Drop.ForeColor = System.Drawing.Color.White;
            this.TextBox_Drop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Drop.Location = new System.Drawing.Point(139, 337);
            this.TextBox_Drop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Drop.Name = "TextBox_Drop";
            this.TextBox_Drop.PasswordChar = '\0';
            this.TextBox_Drop.PlaceholderText = "";
            this.TextBox_Drop.SelectedText = "";
            this.TextBox_Drop.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Drop.TabIndex = 5;
            this.TextBox_Drop.Enter += new System.EventHandler(this.TextBox_Drop_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 415);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Label_date
            // 
            this.Label_date.BackColor = System.Drawing.Color.Transparent;
            this.Label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_date.ForeColor = System.Drawing.Color.White;
            this.Label_date.Location = new System.Drawing.Point(56, 415);
            this.Label_date.Name = "Label_date";
            this.Label_date.Size = new System.Drawing.Size(32, 18);
            this.Label_date.TabIndex = 4;
            this.Label_date.Text = "Date";
            // 
            // Button_Book
            // 
            this.Button_Book.BorderRadius = 10;
            this.Button_Book.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Book.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Book.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Book.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Book.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(29)))));
            this.Button_Book.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Book.ForeColor = System.Drawing.Color.White;
            this.Button_Book.Location = new System.Drawing.Point(227, 455);
            this.Button_Book.Name = "Button_Book";
            this.Button_Book.Size = new System.Drawing.Size(112, 45);
            this.Button_Book.TabIndex = 7;
            this.Button_Book.Text = "Book";
            this.Button_Book.Click += new System.EventHandler(this.Button_Book_Click);
            // 
            // Label_BookVehicle
            // 
            this.Label_BookVehicle.BackColor = System.Drawing.Color.Transparent;
            this.Label_BookVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BookVehicle.ForeColor = System.Drawing.Color.White;
            this.Label_BookVehicle.Location = new System.Drawing.Point(12, 55);
            this.Label_BookVehicle.Name = "Label_BookVehicle";
            this.Label_BookVehicle.Size = new System.Drawing.Size(108, 22);
            this.Label_BookVehicle.TabIndex = 8;
            this.Label_BookVehicle.Text = "Book Vehicle";
            // 
            // Label_PError
            // 
            this.Label_PError.BackColor = System.Drawing.Color.Transparent;
            this.Label_PError.ForeColor = System.Drawing.Color.Red;
            this.Label_PError.Location = new System.Drawing.Point(188, 304);
            this.Label_PError.Name = "Label_PError";
            this.Label_PError.Size = new System.Drawing.Size(3, 2);
            this.Label_PError.TabIndex = 10;
            this.Label_PError.Text = null;
            // 
            // Label_DError
            // 
            this.Label_DError.BackColor = System.Drawing.Color.Transparent;
            this.Label_DError.ForeColor = System.Drawing.Color.Red;
            this.Label_DError.Location = new System.Drawing.Point(188, 379);
            this.Label_DError.Name = "Label_DError";
            this.Label_DError.Size = new System.Drawing.Size(3, 2);
            this.Label_DError.TabIndex = 10;
            this.Label_DError.Text = null;
            // 
            // Taxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(418, 512);
            this.Controls.Add(this.Label_DError);
            this.Controls.Add(this.Label_PError);
            this.Controls.Add(this.Label_BookVehicle);
            this.Controls.Add(this.Button_Book);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TextBox_Drop);
            this.Controls.Add(this.Label_date);
            this.Controls.Add(this.Label_Drop);
            this.Controls.Add(this.TextBox_Pickup);
            this.Controls.Add(this.Label_Pickup);
            this.Controls.Add(this.RadioButton_van);
            this.Controls.Add(this.RadioButton_car);
            this.Controls.Add(this.RadioButton_TukTuk);
            this.Controls.Add(this.PictureBox_van);
            this.Controls.Add(this.PictureBox_car);
            this.Controls.Add(this.PictureBox_Tuk);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Taxi";
            this.Text = "Taxi";
            this.Load += new System.EventHandler(this.Taxi_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_van)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Tuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm_Taxi;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox_Tuk;
        private Guna.UI2.WinForms.Guna2Button Button_Exit;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox_van;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox_car;
        private Guna.UI2.WinForms.Guna2RadioButton RadioButton_van;
        private Guna.UI2.WinForms.Guna2RadioButton RadioButton_car;
        private Guna.UI2.WinForms.Guna2RadioButton RadioButton_TukTuk;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_BookVehicle;
        private Guna.UI2.WinForms.Guna2Button Button_Book;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Drop;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_date;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_Drop;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Pickup;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_Pickup;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_DError;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_PError;
    }
}
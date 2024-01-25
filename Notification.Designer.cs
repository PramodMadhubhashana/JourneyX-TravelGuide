namespace JourneyX
{
    partial class Notification
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
            this.BorderlessForm_Notification = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Button_exit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // BorderlessForm_Notification
            // 
            this.BorderlessForm_Notification.ContainerControl = this;
            this.BorderlessForm_Notification.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm_Notification.ResizeForm = false;
            this.BorderlessForm_Notification.TransparentWhileDrag = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(16, 15);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(112, 27);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Notification";
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
            this.Button_exit.ForeColor = System.Drawing.Color.White;
            this.Button_exit.Image = global::JourneyX.Properties.Resources.cancel;
            this.Button_exit.ImageSize = new System.Drawing.Size(16, 16);
            this.Button_exit.Location = new System.Drawing.Point(323, 9);
            this.Button_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(35, 32);
            this.Button_exit.TabIndex = 1;
            this.Button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(373, 530);
            this.Controls.Add(this.Button_exit);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Notification";
            this.Text = "Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm_Notification;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button Button_exit;
    }
}
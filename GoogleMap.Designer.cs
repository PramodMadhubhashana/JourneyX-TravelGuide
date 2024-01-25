namespace JourneyX
{
    partial class GoogleMap
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
            this.Panel_ControlPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Button_Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Maximize = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Form_GoogleMap = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2WinProgressIndicator = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.webBrowser_GoogleMap = new System.Windows.Forms.WebBrowser();
            this.Panel_ControlPanel.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_ControlPanel
            // 
            this.Panel_ControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.Panel_ControlPanel.Controls.Add(this.Button_Minimize);
            this.Panel_ControlPanel.Controls.Add(this.Button_Exit);
            this.Panel_ControlPanel.Controls.Add(this.Button_Maximize);
            this.Panel_ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_ControlPanel.Location = new System.Drawing.Point(735, 0);
            this.Panel_ControlPanel.Name = "Panel_ControlPanel";
            this.Panel_ControlPanel.Size = new System.Drawing.Size(86, 38);
            this.Panel_ControlPanel.TabIndex = 0;
            // 
            // Button_Minimize
            // 
            this.Button_Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Minimize.FillColor = System.Drawing.Color.Transparent;
            this.Button_Minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Minimize.ForeColor = System.Drawing.Color.White;
            
            this.Button_Minimize.ImageSize = new System.Drawing.Size(15, 15);
            this.Button_Minimize.Location = new System.Drawing.Point(4, 0);
            this.Button_Minimize.Name = "Button_Minimize";
            this.Button_Minimize.Size = new System.Drawing.Size(26, 26);
            this.Button_Minimize.TabIndex = 1;
            this.Button_Minimize.Click += new System.EventHandler(this.Button_Minimize_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Exit.FillColor = System.Drawing.Color.Transparent;
            this.Button_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Exit.ForeColor = System.Drawing.Color.White;
            
            this.Button_Exit.ImageSize = new System.Drawing.Size(15, 15);
            this.Button_Exit.Location = new System.Drawing.Point(56, 0);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(26, 26);
            this.Button_Exit.TabIndex = 1;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Maximize
            // 
            this.Button_Maximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Maximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Maximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Maximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Maximize.FillColor = System.Drawing.Color.Transparent;
            this.Button_Maximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Maximize.ForeColor = System.Drawing.Color.White;
            this.Button_Maximize.Image = global::JourneyX.Properties.Resources.maximize;
            this.Button_Maximize.ImageSize = new System.Drawing.Size(15, 15);
            this.Button_Maximize.Location = new System.Drawing.Point(30, 0);
            this.Button_Maximize.Name = "Button_Maximize";
            this.Button_Maximize.Size = new System.Drawing.Size(26, 26);
            this.Button_Maximize.TabIndex = 3;
            this.Button_Maximize.Click += new System.EventHandler(this.Button_Maximize_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.Panel_ControlPanel);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Cyan;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.DarkOrchid;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(821, 38);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // Form_GoogleMap
            // 
            this.Form_GoogleMap.ContainerControl = this;
            this.Form_GoogleMap.DockIndicatorTransparencyValue = 0.6D;
            this.Form_GoogleMap.TransparentWhileDrag = true;
            // 
            // guna2WinProgressIndicator
            // 
            this.guna2WinProgressIndicator.BackColor = System.Drawing.Color.White;
            this.guna2WinProgressIndicator.Location = new System.Drawing.Point(364, 157);
            this.guna2WinProgressIndicator.Name = "guna2WinProgressIndicator";
            this.guna2WinProgressIndicator.ProgressColor = System.Drawing.Color.DarkOrchid;
            this.guna2WinProgressIndicator.Size = new System.Drawing.Size(110, 90);
            this.guna2WinProgressIndicator.TabIndex = 3;
            this.guna2WinProgressIndicator.Click += new System.EventHandler(this.guna2WinProgressIndicator_Click);
            // 
            // webBrowser_GoogleMap
            // 
            this.webBrowser_GoogleMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_GoogleMap.Location = new System.Drawing.Point(0, 38);
            this.webBrowser_GoogleMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_GoogleMap.Name = "webBrowser_GoogleMap";
            this.webBrowser_GoogleMap.Size = new System.Drawing.Size(821, 443);
            this.webBrowser_GoogleMap.TabIndex = 2;
            this.webBrowser_GoogleMap.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_GoogleMap_DocumentCompleted);
            // 
            // GoogleMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 481);
            this.Controls.Add(this.guna2WinProgressIndicator);
            this.Controls.Add(this.webBrowser_GoogleMap);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(821, 481);
            this.Name = "GoogleMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoogleMap";
            this.Load += new System.EventHandler(this.GoogleMap_Load);
            this.Panel_ControlPanel.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel Panel_ControlPanel;
        private Guna.UI2.WinForms.Guna2Button Button_Minimize;
        private Guna.UI2.WinForms.Guna2Button Button_Exit;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm Form_GoogleMap;
        private Guna.UI2.WinForms.Guna2Button Button_Maximize;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator;
        private System.Windows.Forms.WebBrowser webBrowser_GoogleMap;
    }
}
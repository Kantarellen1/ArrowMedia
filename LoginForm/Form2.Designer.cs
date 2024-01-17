namespace LoginForm
{
    partial class Interface
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
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.ControlButton = new System.Windows.Forms.Button();
            this.DataButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DimGray;
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.AboutPanel);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(226, 688);
            this.sidebar.MinimumSize = new System.Drawing.Size(73, 688);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(73, 688);
            this.sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MenuButton);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 100);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.HomeButton);
            this.panel3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 68);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ControlButton);
            this.panel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 68);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DataButton);
            this.panel4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(3, 257);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 68);
            this.panel4.TabIndex = 8;
            // 
            // AboutPanel
            // 
            this.AboutPanel.Controls.Add(this.AboutButton);
            this.AboutPanel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutPanel.Location = new System.Drawing.Point(3, 331);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(221, 68);
            this.AboutPanel.TabIndex = 9;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 405);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 96);
            this.panel5.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(3, 507);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 75);
            this.panel6.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button1);
            this.panel7.Location = new System.Drawing.Point(3, 588);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(361, 100);
            this.panel7.TabIndex = 13;
            // 
            // MenuButton
            // 
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.Image = global::LoginForm.Properties.Resources.MenuButton;
            this.MenuButton.Location = new System.Drawing.Point(-185, -13);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(439, 122);
            this.MenuButton.TabIndex = 10;
            this.MenuButton.Text = "                                     Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Image = global::LoginForm.Properties.Resources.HomeButton;
            this.HomeButton.Location = new System.Drawing.Point(-30, -21);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(284, 102);
            this.HomeButton.TabIndex = 7;
            this.HomeButton.Text = "     Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // ControlButton
            // 
            this.ControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlButton.Image = global::LoginForm.Properties.Resources.ControllerButton;
            this.ControlButton.Location = new System.Drawing.Point(-19, -13);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(249, 90);
            this.ControlButton.TabIndex = 5;
            this.ControlButton.Text = "      Controls";
            this.ControlButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // DataButton
            // 
            this.DataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataButton.Image = global::LoginForm.Properties.Resources.DataButton;
            this.DataButton.Location = new System.Drawing.Point(-33, -11);
            this.DataButton.Name = "DataButton";
            this.DataButton.Size = new System.Drawing.Size(278, 90);
            this.DataButton.TabIndex = 9;
            this.DataButton.Text = "     Data";
            this.DataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataButton.UseVisualStyleBackColor = true;
            this.DataButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Image = global::LoginForm.Properties.Resources.AboutButton;
            this.AboutButton.Location = new System.Drawing.Point(-30, -11);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(284, 90);
            this.AboutButton.TabIndex = 10;
            this.AboutButton.Text = "      About";
            this.AboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AboutButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::LoginForm.Properties.Resources.SettingsButton;
            this.button1.Location = new System.Drawing.Point(-60, -19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(418, 130);
            this.button1.TabIndex = 10;
            this.button1.Text = "     Settings";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 688);
            this.Controls.Add(this.sidebar);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.AboutPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button DataButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}
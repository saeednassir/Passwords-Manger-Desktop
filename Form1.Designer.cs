namespace PasswordsManager_Desktop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pcMinimized = new System.Windows.Forms.PictureBox();
            this.pcClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcIcon = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDeletePassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnGetPassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnListPasswords = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcon)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.panelHeader.Controls.Add(this.pcMinimized);
            this.panelHeader.Controls.Add(this.pcClose);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.pcIcon);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(850, 53);
            this.panelHeader.TabIndex = 0;
            // 
            // pcMinimized
            // 
            this.pcMinimized.Image = ((System.Drawing.Image)(resources.GetObject("pcMinimized.Image")));
            this.pcMinimized.Location = new System.Drawing.Point(69, 6);
            this.pcMinimized.Name = "pcMinimized";
            this.pcMinimized.Size = new System.Drawing.Size(40, 40);
            this.pcMinimized.TabIndex = 5;
            this.pcMinimized.TabStop = false;
            this.pcMinimized.Click += new System.EventHandler(this.pcMinemum_Click);
            // 
            // pcClose
            // 
            this.pcClose.Image = ((System.Drawing.Image)(resources.GetObject("pcClose.Image")));
            this.pcClose.Location = new System.Drawing.Point(14, 6);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(40, 40);
            this.pcClose.TabIndex = 4;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.pcClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(647, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "إدارة كلمات المرور";
            // 
            // pcIcon
            // 
            this.pcIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcIcon.Image")));
            this.pcIcon.Location = new System.Drawing.Point(798, 6);
            this.pcIcon.Name = "pcIcon";
            this.pcIcon.Size = new System.Drawing.Size(40, 40);
            this.pcIcon.TabIndex = 2;
            this.pcIcon.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.btnDeletePassword);
            this.panelMenu.Controls.Add(this.btnGetPassword);
            this.panelMenu.Controls.Add(this.btnAddChangePassword);
            this.panelMenu.Controls.Add(this.btnListPasswords);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 53);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(850, 48);
            this.panelMenu.TabIndex = 1;
            // 
            // btnDeletePassword
            // 
            this.btnDeletePassword.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeletePassword.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDeletePassword.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnDeletePassword.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDeletePassword.CheckedState.Parent = this.btnDeletePassword;
            this.btnDeletePassword.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDeletePassword.CustomImages.Parent = this.btnDeletePassword;
            this.btnDeletePassword.FillColor = System.Drawing.Color.White;
            this.btnDeletePassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeletePassword.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnDeletePassword.HoverState.Parent = this.btnDeletePassword;
            this.btnDeletePassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDeletePassword.Location = new System.Drawing.Point(69, -1);
            this.btnDeletePassword.Name = "btnDeletePassword";
            this.btnDeletePassword.ShadowDecoration.Parent = this.btnDeletePassword;
            this.btnDeletePassword.Size = new System.Drawing.Size(190, 47);
            this.btnDeletePassword.TabIndex = 0;
            this.btnDeletePassword.Text = "حذف كلمة مرور";
            this.btnDeletePassword.Click += new System.EventHandler(this.btnDeletePassword_Click);
            // 
            // btnGetPassword
            // 
            this.btnGetPassword.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetPassword.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGetPassword.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnGetPassword.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnGetPassword.CheckedState.Parent = this.btnGetPassword;
            this.btnGetPassword.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnGetPassword.CustomImages.Parent = this.btnGetPassword;
            this.btnGetPassword.FillColor = System.Drawing.Color.White;
            this.btnGetPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGetPassword.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnGetPassword.HoverState.Parent = this.btnGetPassword;
            this.btnGetPassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnGetPassword.Location = new System.Drawing.Point(265, -1);
            this.btnGetPassword.Name = "btnGetPassword";
            this.btnGetPassword.ShadowDecoration.Parent = this.btnGetPassword;
            this.btnGetPassword.Size = new System.Drawing.Size(190, 47);
            this.btnGetPassword.TabIndex = 0;
            this.btnGetPassword.Text = "بحث عن كلمة مرور";
            this.btnGetPassword.Click += new System.EventHandler(this.btnGetPassword_Click);
            // 
            // btnAddChangePassword
            // 
            this.btnAddChangePassword.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddChangePassword.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddChangePassword.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnAddChangePassword.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddChangePassword.CheckedState.Parent = this.btnAddChangePassword;
            this.btnAddChangePassword.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAddChangePassword.CustomImages.Parent = this.btnAddChangePassword;
            this.btnAddChangePassword.FillColor = System.Drawing.Color.White;
            this.btnAddChangePassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddChangePassword.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnAddChangePassword.HoverState.Parent = this.btnAddChangePassword;
            this.btnAddChangePassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddChangePassword.Location = new System.Drawing.Point(461, -1);
            this.btnAddChangePassword.Name = "btnAddChangePassword";
            this.btnAddChangePassword.ShadowDecoration.Parent = this.btnAddChangePassword;
            this.btnAddChangePassword.Size = new System.Drawing.Size(190, 47);
            this.btnAddChangePassword.TabIndex = 0;
            this.btnAddChangePassword.Text = "إضافة - تعديل المرور";
            this.btnAddChangePassword.Click += new System.EventHandler(this.btnAddChangePassword_Click);
            // 
            // btnListPasswords
            // 
            this.btnListPasswords.BackColor = System.Drawing.Color.White;
            this.btnListPasswords.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnListPasswords.Checked = true;
            this.btnListPasswords.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnListPasswords.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnListPasswords.CheckedState.Parent = this.btnListPasswords;
            this.btnListPasswords.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnListPasswords.CustomImages.Parent = this.btnListPasswords;
            this.btnListPasswords.FillColor = System.Drawing.Color.White;
            this.btnListPasswords.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListPasswords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListPasswords.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnListPasswords.HoverState.Parent = this.btnListPasswords;
            this.btnListPasswords.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnListPasswords.Location = new System.Drawing.Point(657, -1);
            this.btnListPasswords.Name = "btnListPasswords";
            this.btnListPasswords.ShadowDecoration.Parent = this.btnListPasswords;
            this.btnListPasswords.Size = new System.Drawing.Size(190, 47);
            this.btnListPasswords.TabIndex = 0;
            this.btnListPasswords.Text = "كلمات المرور";
            this.btnListPasswords.Click += new System.EventHandler(this.btnListPasswords_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 1);
            this.panel2.TabIndex = 2;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 102);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(850, 409);
            this.panelContainer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(850, 511);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة كلمات المرور";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcon)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pcIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcClose;
        private System.Windows.Forms.PictureBox pcMinimized;
        private Guna.UI2.WinForms.Guna2Button btnDeletePassword;
        private Guna.UI2.WinForms.Guna2Button btnGetPassword;
        private Guna.UI2.WinForms.Guna2Button btnAddChangePassword;
        private Guna.UI2.WinForms.Guna2Button btnListPasswords;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainer;
    }
}


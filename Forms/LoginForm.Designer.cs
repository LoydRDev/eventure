using System.Windows.Forms;

namespace eventure.Forms
{
    partial class LoginForm
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
            System.Windows.Forms.TabPage tabRegistration;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TBUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.TBConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBPasswordReg = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.TBFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLoginForm = new Guna.UI2.WinForms.Guna2Button();
            this.formControl = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPasswordTextBox = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUsernameTextBox = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnRegisterForm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            tabRegistration = new System.Windows.Forms.TabPage();
            tabRegistration.SuspendLayout();
            this.formControl.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRegistration
            // 
            tabRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            tabRegistration.Controls.Add(this.TBUsername);
            tabRegistration.Controls.Add(this.guna2GradientPanel1);
            tabRegistration.Controls.Add(this.TBConfirmPassword);
            tabRegistration.Controls.Add(this.TBPasswordReg);
            tabRegistration.Controls.Add(this.TBEmail);
            tabRegistration.Controls.Add(this.TBLastName);
            tabRegistration.Controls.Add(this.BtnRegister);
            tabRegistration.Controls.Add(this.TBFirstName);
            tabRegistration.Controls.Add(this.guna2HtmlLabel2);
            tabRegistration.Controls.Add(this.guna2HtmlLabel1);
            tabRegistration.Controls.Add(this.btnLoginForm);
            tabRegistration.Location = new System.Drawing.Point(4, 22);
            tabRegistration.Name = "tabRegistration";
            tabRegistration.Padding = new System.Windows.Forms.Padding(3);
            tabRegistration.Size = new System.Drawing.Size(1000, 653);
            tabRegistration.TabIndex = 1;
            tabRegistration.Text = "tabPage2";
            // 
            // TBUsername
            // 
            this.TBUsername.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TBUsername.BorderRadius = 12;
            this.TBUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBUsername.DefaultText = "";
            this.TBUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TBUsername.ForeColor = System.Drawing.Color.Black;
            this.TBUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBUsername.Location = new System.Drawing.Point(558, 262);
            this.TBUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.TBUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TBUsername.PlaceholderText = "Username";
            this.TBUsername.SelectedText = "";
            this.TBUsername.Size = new System.Drawing.Size(375, 36);
            this.TBUsername.TabIndex = 14;
            this.TBUsername.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(40, 51);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(443, 505);
            this.guna2GradientPanel1.TabIndex = 13;
            // 
            // TBConfirmPassword
            // 
            this.TBConfirmPassword.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TBConfirmPassword.BorderRadius = 12;
            this.TBConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBConfirmPassword.DefaultText = "";
            this.TBConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TBConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.TBConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBConfirmPassword.Location = new System.Drawing.Point(558, 412);
            this.TBConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBConfirmPassword.Name = "TBConfirmPassword";
            this.TBConfirmPassword.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.TBConfirmPassword.PasswordChar = '●';
            this.TBConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TBConfirmPassword.PlaceholderText = "Confirm Password";
            this.TBConfirmPassword.SelectedText = "";
            this.TBConfirmPassword.Size = new System.Drawing.Size(375, 36);
            this.TBConfirmPassword.TabIndex = 12;
            this.TBConfirmPassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // TBPasswordReg
            // 
            this.TBPasswordReg.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TBPasswordReg.BorderRadius = 12;
            this.TBPasswordReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBPasswordReg.DefaultText = "";
            this.TBPasswordReg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBPasswordReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBPasswordReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBPasswordReg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBPasswordReg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBPasswordReg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TBPasswordReg.ForeColor = System.Drawing.Color.Black;
            this.TBPasswordReg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBPasswordReg.Location = new System.Drawing.Point(558, 361);
            this.TBPasswordReg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBPasswordReg.Name = "TBPasswordReg";
            this.TBPasswordReg.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.TBPasswordReg.PasswordChar = '●';
            this.TBPasswordReg.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TBPasswordReg.PlaceholderText = "Password";
            this.TBPasswordReg.SelectedText = "";
            this.TBPasswordReg.Size = new System.Drawing.Size(375, 36);
            this.TBPasswordReg.TabIndex = 11;
            this.TBPasswordReg.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // TBEmail
            // 
            this.TBEmail.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TBEmail.BorderRadius = 12;
            this.TBEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBEmail.DefaultText = "";
            this.TBEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TBEmail.ForeColor = System.Drawing.Color.Black;
            this.TBEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBEmail.Location = new System.Drawing.Point(558, 310);
            this.TBEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.TBEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TBEmail.PlaceholderText = "Email";
            this.TBEmail.SelectedText = "";
            this.TBEmail.Size = new System.Drawing.Size(375, 36);
            this.TBEmail.TabIndex = 10;
            this.TBEmail.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // TBLastName
            // 
            this.TBLastName.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TBLastName.BorderRadius = 12;
            this.TBLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBLastName.DefaultText = "";
            this.TBLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TBLastName.ForeColor = System.Drawing.Color.Black;
            this.TBLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBLastName.Location = new System.Drawing.Point(751, 209);
            this.TBLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.TBLastName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TBLastName.PlaceholderText = "Last Name";
            this.TBLastName.SelectedText = "";
            this.TBLastName.Size = new System.Drawing.Size(182, 36);
            this.TBLastName.TabIndex = 9;
            this.TBLastName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // BtnRegister
            // 
            this.BtnRegister.BorderRadius = 12;
            this.BtnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRegister.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(558, 503);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(375, 39);
            this.BtnRegister.TabIndex = 8;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // TBFirstName
            // 
            this.TBFirstName.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TBFirstName.BorderRadius = 12;
            this.TBFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBFirstName.DefaultText = "";
            this.TBFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TBFirstName.ForeColor = System.Drawing.Color.Black;
            this.TBFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBFirstName.Location = new System.Drawing.Point(558, 209);
            this.TBFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.TBFirstName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TBFirstName.PlaceholderText = "First Name";
            this.TBFirstName.SelectedText = "";
            this.TBFirstName.Size = new System.Drawing.Size(182, 36);
            this.TBFirstName.TabIndex = 3;
            this.TBFirstName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(547, 154);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(183, 18);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Already have an account?";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(535, 79);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(314, 42);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Create an account";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLoginForm
            // 
            this.btnLoginForm.BorderColor = System.Drawing.Color.Transparent;
            this.btnLoginForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginForm.DefaultAutoSize = true;
            this.btnLoginForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoginForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoginForm.FillColor = System.Drawing.Color.Transparent;
            this.btnLoginForm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginForm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLoginForm.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLoginForm.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnLoginForm.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLoginForm.Location = new System.Drawing.Point(718, 147);
            this.btnLoginForm.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnLoginForm.Name = "btnLoginForm";
            this.btnLoginForm.Size = new System.Drawing.Size(98, 28);
            this.btnLoginForm.TabIndex = 0;
            this.btnLoginForm.Text = "Login here!";
            this.btnLoginForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLoginForm.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // formControl
            // 
            this.formControl.Controls.Add(this.tabLogin);
            this.formControl.Controls.Add(tabRegistration);
            this.formControl.Location = new System.Drawing.Point(-4, -23);
            this.formControl.Name = "formControl";
            this.formControl.SelectedIndex = 0;
            this.formControl.Size = new System.Drawing.Size(1008, 679);
            this.formControl.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabLogin.Controls.Add(this.guna2ImageButton4);
            this.tabLogin.Controls.Add(this.guna2ImageButton3);
            this.tabLogin.Controls.Add(this.guna2ImageButton1);
            this.tabLogin.Controls.Add(this.lblTitle);
            this.tabLogin.Controls.Add(this.guna2Panel1);
            this.tabLogin.Controls.Add(this.lblPasswordTextBox);
            this.tabLogin.Controls.Add(this.tbPassword);
            this.tabLogin.Controls.Add(this.lblUsernameTextBox);
            this.tabLogin.Controls.Add(this.btnRegisterForm);
            this.tabLogin.Controls.Add(this.guna2TextBox1);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.tabLogin.Size = new System.Drawing.Size(1000, 653);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "tabPage1";
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton4.Image")));
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.Location = new System.Drawing.Point(945, 8);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.Size = new System.Drawing.Size(43, 40);
            this.guna2ImageButton4.TabIndex = 8;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.Location = new System.Drawing.Point(891, 8);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Size = new System.Drawing.Size(43, 40);
            this.guna2ImageButton3.TabIndex = 7;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(186, 54);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(91, 70);
            this.guna2ImageButton1.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(123, 144);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 42);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Welcome back";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.Location = new System.Drawing.Point(470, 71);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(479, 485);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lblPasswordTextBox
            // 
            this.lblPasswordTextBox.AutoSize = false;
            this.lblPasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPasswordTextBox.Location = new System.Drawing.Point(69, 302);
            this.lblPasswordTextBox.Name = "lblPasswordTextBox";
            this.lblPasswordTextBox.Size = new System.Drawing.Size(103, 27);
            this.lblPasswordTextBox.TabIndex = 4;
            this.lblPasswordTextBox.Text = "Password";
            this.lblPasswordTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPassword.BorderRadius = 12;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(60, 335);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(343, 36);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblUsernameTextBox
            // 
            this.lblUsernameTextBox.AutoSize = false;
            this.lblUsernameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsernameTextBox.Location = new System.Drawing.Point(69, 220);
            this.lblUsernameTextBox.Name = "lblUsernameTextBox";
            this.lblUsernameTextBox.Size = new System.Drawing.Size(103, 27);
            this.lblUsernameTextBox.TabIndex = 3;
            this.lblUsernameTextBox.Text = "Username";
            this.lblUsernameTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegisterForm
            // 
            this.btnRegisterForm.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegisterForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegisterForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegisterForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegisterForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegisterForm.FillColor = System.Drawing.Color.Transparent;
            this.btnRegisterForm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnRegisterForm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRegisterForm.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegisterForm.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnRegisterForm.Location = new System.Drawing.Point(69, 428);
            this.btnRegisterForm.Name = "btnRegisterForm";
            this.btnRegisterForm.PressedColor = System.Drawing.Color.Transparent;
            this.btnRegisterForm.Size = new System.Drawing.Size(126, 45);
            this.btnRegisterForm.TabIndex = 0;
            this.btnRegisterForm.Text = "Register here!";
            this.btnRegisterForm.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2TextBox1.BorderRadius = 12;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(60, 253);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(343, 36);
            this.guna2TextBox1.TabIndex = 0;
            this.guna2TextBox1.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 12;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(246, 428);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 45);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.formControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            tabRegistration.ResumeLayout(false);
            tabRegistration.PerformLayout();
            this.formControl.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl formControl;
        private System.Windows.Forms.TabPage tabLogin;
        private Guna.UI2.WinForms.Guna2Button btnRegisterForm;
        private Guna.UI2.WinForms.Guna2Button btnLoginForm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsernameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPasswordTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button BtnRegister;
        private Guna.UI2.WinForms.Guna2TextBox TBFirstName;
        private Guna.UI2.WinForms.Guna2TextBox TBConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox TBPasswordReg;
        private Guna.UI2.WinForms.Guna2TextBox TBEmail;
        private Guna.UI2.WinForms.Guna2TextBox TBLastName;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox TBUsername;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
    }
}
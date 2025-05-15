using eventure.DataAccess;
using eventure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace eventure.Forms
{
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            formControl.SelectedIndex = 1;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            formControl.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboard = new Dashboard();
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                FirstName = TBFirstName.Text,
                LastName = TBLastName.Text,
                Username = TBUsername.Text,
                Email = TBEmail.Text,
                Password = TBConfirmPassword.Text,
                DateCreated = DateTime.Now,
            };

            try
            {
                new UserDAO().AddUser(newUser);
                var result = MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    formControl.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

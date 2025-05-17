using System;
using System.Drawing;
using System.Windows.Forms;

using eventure.DataAccess;
using eventure.Models;

namespace eventure.Forms
{
    public partial class LoginForm : Form
    {
        UserDAO userDAO = new UserDAO();
        int i = 1;
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
            string username = TBLoginUsername.Text.Trim();
            string password = TBLoginPassword.Text.Trim();

            User loggedInUser = userDAO.AuthenticateUser(username, password);
            
            if (loggedInUser != null)
            {
                int UserID = loggedInUser.UserID;
                MessageBox.Show($"Welcome, {loggedInUser.FirstName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                var dashboard = new Dashboard(UserID);
                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (Validations())
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

        private bool Validations()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(TBFirstName.Text))
            {
                TBFirstName.BorderColor = Color.Red;
                TBFirstName.Focus();
                isValid = false;
            }
            else
            {
                TBFirstName.BorderColor = Color.Green;
            }
            if (string.IsNullOrWhiteSpace(TBLastName.Text))
            {
                TBLastName.BorderColor = Color.Red;
                TBLastName.Focus();
                isValid = false;
            }
            else
            {
                TBLastName.BorderColor = Color.Green;
            }
            if (string.IsNullOrWhiteSpace(TBUsername.Text))
            {
                TBUsername.BorderColor = Color.Red;
                TBUsername.Focus();
                isValid = false;
            }
            else
            {
                TBUsername.BorderColor = Color.Green;
            }
            if (string.IsNullOrWhiteSpace(TBEmail.Text))
            {
                TBEmail.BorderColor = Color.Red;
                TBEmail.Focus();
                isValid = false;
            }
            else
            {
                TBEmail.BorderColor = Color.Green;
            }
            if (string.IsNullOrWhiteSpace(TBPassword.Text))
            {
                TBPassword.BorderColor = Color.Red;
                TBPassword.Focus();
                isValid = false;
            }
            else
            {
                TBPassword.BorderColor = Color.Green;
            }
            if (string.IsNullOrWhiteSpace(TBConfirmPassword.Text))
            {
                TBConfirmPassword.BorderColor = Color.Red;
                TBConfirmPassword.Focus();
                isValid = false;
            }
            else
            {
                TBConfirmPassword.BorderColor = Color.Green;
            }
            if (!isValid)
            {
                MessageBox.Show("Please fill in all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return isValid;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > 5)
            {
                i = 1;
            }
            string images = @"C:\Users\black\OneDrive\Desktop\eventure\Images\"+i.ToString() +".jpg";
            ImageSlider.Image = Image.FromFile(images);
            ImageSlider2.Image = Image.FromFile(images);
        }
    }
}

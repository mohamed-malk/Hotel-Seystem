using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Hotel_System_Front
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login secondForm = new Login();
            secondForm.ShowDialog();
            // this.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login secondForm = new Login();
            secondForm.ShowDialog();
            //this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                if (Regex.IsMatch(NationalId.Text, "[a-zA-Z]") || NationalId.Text.Length != 14)
                {
                    errorProvider1.SetError(NationalId, "NID must be 14 numbers");
                    return;
                }
                if (!Regex.IsMatch(UserName.Text, "^[a-zA-Z]+$"))
                {
                    errorProvider2.SetError(UserName, "Username should only contain letters.");
                    return;
                }
                else
                {
                    errorProvider2.SetError(UserName, "");
                }

                // Validation for Email TextBox
                if (string.IsNullOrWhiteSpace(Email.Text) || !Email.Text.Contains("@") || !Email.Text.Contains("."))
                {
                    errorProvider3.SetError(Email, "Please enter a valid email address.");
                    return;
                }
                else
                {
                    errorProvider3.SetError(Email, "");
                }

                // Validation for Password TextBox
                if (string.IsNullOrWhiteSpace(Password.Text))
                {
                    errorProvider4.SetError(Password, "Please enter a password.");
                    return;
                }
                else
                {
                    errorProvider4.SetError(Password, "");
                }

                // Validation for ConfirmPassword TextBox
                if (ConfirmPassword.Text != Password.Text)
                {
                    errorProvider5.SetError(ConfirmPassword, "Passwords do not match.");
                    return;
                }
                else
                {
                    errorProvider5.SetError(ConfirmPassword, "");

                    ClientRepo clientRepo = new ClientRepo();
                    MyProfile secondForm =
                        new MyProfile(clientRepo.Add(UserName.Text, Email.Text, Password.Text, NationalId.Text));

                    this.Close();
                    this.Hide();
                    secondForm.ShowDialog();
                    //this.Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}

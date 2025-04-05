using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BTM_495_Final_Prototype
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Sets the form start position to the screen center
        }

        private void LoginButton_Click(object sender, EventArgs e) // this method deals with a click event on the login button.
        {
            UserHandler uHandler = new UserHandler(); // creating new user handelr object to handel the authentication
            bool outcome = uHandler.authenticate(EmailBox.Text, PasswordBox.Text);
            if (outcome) // if authentication was successful and a matching user/password combo was found in the database
            {
                uHandler.dashboard(EmailBox.Text, PasswordBox.Text); // after successful authentication, calling the dashboard method from user handler to construct user dashboard
            }
        }

        private void RegisterLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // this method handels the users selection to register a new account
        {
            DetailsForm details = new DetailsForm(); // creating new details form 
            details.CreateUser(); // setting the form for user creation
            details.Show(); // display the registration form
        }

        private void SeeCheck_CheckedChanged(object sender, EventArgs e) // this method handles the user's selection to show/hide the password input
        {
            if (SeeCheck.Checked == true)
            {
                PasswordBox.PasswordChar = '\0'; // showing passwod input if the user selects to show it
            }
            else
            {
                PasswordBox.PasswordChar = '*'; // hidind passwod input if user de-selects the option to show it
            }
        }

        private void faqLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // FAQ function for the login page.
        {
            FaqForm faq = new FaqForm();
            faq.Show();
        }
    }
}

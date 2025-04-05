using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BTM_495_Final_Prototype
{
    public partial class DetailsForm : Form
    {
        bool update = false; // holding the state of the form
        int uID = -1; // userID to be used for updating operations
        public DetailsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Sets the form start position to the screen center
            deactivateCheck.Visible = false; // hiding the deactivation check
        }

        public void CreateUser()
        {
            technitianCheck.Visible = false;
            titleBox.Visible = false;
            titleLabel.Visible = false;
            impTitleLabel.Visible = false;
            formTitleLabel.Text = "User Registration:";
        }

        public void CreateTechnician()
        {
            formTitleLabel.Text = "Tachnician Registration:";
        }

        public void ValidateDetails() // this method validates that all mandatory details were inserted, as well as relevant contraints for these details
        {
            if (this.update == false) // validation process for a creating a new user
            {
                if (technitianCheck.Visible == false) // field inspections in case of normal user creation
                {
                    SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
                    connection.Open(); // opening a new connection to the local database
                    string query = "SELECT count(*) FROM users WHERE email=@email"; // query to check email availability
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@email", emailBox.Text); // inserting user input into query
                    int count = (int)cmd.ExecuteScalar(); // counter variable to see if there are any matches

                    if (count > 0) // checking if the email is already in use
                    {
                        MessageBox.Show("Please use another Email address.");
                    }
                    else if (fnBox.Text == "" || lnBox.Text == "" || emailBox.Text == "" || passBox.Text == "" || verifyBox.Text == "" || addressBox.Text == "" || DateTime.Now.Year - datePicker.Value.Year < 18 || verifyCheck.Checked == false)
                    {
                        MessageBox.Show("Please fill up all the mandatory fields and checks.");
                    }
                    else if (!string.Equals(passBox.Text, verifyBox.Text)) // if entered passwords do not match
                    {
                        MessageBox.Show("Passwords do not match.");
                    }
                    else if (passBox.Text.Length < 6 || passBox.Text.Length > 24)
                    {
                        MessageBox.Show("Passwords must be between 6 and 24 characters long.");
                    }
                    else // if details passed all validation checks
                    {
                        if (policyBox.Text == "") // handeling case where user did not enter any policy ID
                        {
                            policyBox.Text = "-1";
                        }
                        query = "INSERT INTO users (fName, lName, email, pass, address, policyID, technician, title, deactivated, bDate) VALUES (@fName, @lName, @email, @pass, @address, @policyID, @technician, @title, @deactivated, @bDate)"; // insertion command
                        cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@fName", fnBox.Text);
                        cmd.Parameters.AddWithValue("@lName", lnBox.Text);
                        cmd.Parameters.AddWithValue("@email", emailBox.Text);
                        cmd.Parameters.AddWithValue("@pass", passBox.Text);
                        cmd.Parameters.AddWithValue("@address", addressBox.Text);
                        cmd.Parameters.AddWithValue("@policyID", policyBox.Text);
                        cmd.Parameters.AddWithValue("@technician", false);
                        cmd.Parameters.AddWithValue("@title", "Customer");
                        cmd.Parameters.AddWithValue("@deactivated", false);
                        cmd.Parameters.AddWithValue("@bDate", datePicker.Value);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User for " + fnBox.Text + " " + lnBox.Text + " was created succesfuly!\nReturning to login page.");
                        connection.Close(); // closing the connection after capturing the user information
                        Close();
                    }
                }
                else // field inspections in case of a technitian user creation
                {

                    SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
                    connection.Open(); // opening a new connection to the local database
                    string query = "SELECT count(*) FROM users WHERE email=@email"; // query to check email availability
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@email", emailBox.Text); // inserting user input into query
                    int count = (int)cmd.ExecuteScalar(); // counter variable to see if there are any matches

                    if (count > 0) // checking if the email is already in use
                    {
                        MessageBox.Show("Please use another Email address.");
                    }
                    else if (fnBox.Text == "" || lnBox.Text == "" || emailBox.Text == "" || passBox.Text == "" || verifyBox.Text == "" || addressBox.Text == "" || DateTime.Now.Year - datePicker.Value.Year < 18 || verifyCheck.Checked == false || titleBox.Text == "")
                    {
                        MessageBox.Show("Please fill up all the mandatory fields and checks.");
                    }
                    else if (!string.Equals(passBox.Text, verifyBox.Text)) // if entered passwords do not match
                    {
                        MessageBox.Show("Passwords do not match.");
                    }
                    else if (passBox.Text.Length < 6 || passBox.Text.Length > 24)
                    {
                        MessageBox.Show("Passwords must be between 6 and 24 characters long.");
                    }
                    else // if details passed all validation checks
                    {
                        if (policyBox.Text == "") // handeling case where user did not enter any policy ID
                        {
                            policyBox.Text = "-1";
                        }
                        query = "INSERT INTO users (fName, lName, email, pass, address, policyID, technician, title, deactivated, bDate) VALUES (@fName, @lName, @email, @pass, @address, @policyID, @technician, @title, @deactivated, @bDate)"; // insertion command
                        cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@fName", fnBox.Text);
                        cmd.Parameters.AddWithValue("@lName", lnBox.Text);
                        cmd.Parameters.AddWithValue("@email", emailBox.Text);
                        cmd.Parameters.AddWithValue("@pass", passBox.Text);
                        cmd.Parameters.AddWithValue("@address", addressBox.Text);
                        cmd.Parameters.AddWithValue("@policyID", policyBox.Text);
                        cmd.Parameters.AddWithValue("@technician", technitianCheck.Checked);
                        cmd.Parameters.AddWithValue("@title", titleBox.Text);
                        cmd.Parameters.AddWithValue("@deactivated", false);
                        cmd.Parameters.AddWithValue("@bDate", datePicker.Value);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User for " + fnBox.Text + " " + lnBox.Text + " was created succesfuly!\nReturning to dashboard.");
                        connection.Close(); // closing the connection after capturing the user information
                        Close();
                    }
                }
            }
            else // valdiation input process for updating a user
            {

                if (technitianCheck.Visible == false) // field inspections in case of normal user creation
                {
                    if (fnBox.Text == "" || lnBox.Text == "" || emailBox.Text == "" || passBox.Text == "" || verifyBox.Text == "" || addressBox.Text == "" || DateTime.Now.Year - datePicker.Value.Year < 18 || verifyCheck.Checked == false)
                    {
                        MessageBox.Show("Please fill up all the mandatory fields and checks.");
                    }
                    else if (!string.Equals(passBox.Text, verifyBox.Text)) // if entered passwords do not match
                    {
                        MessageBox.Show("Passwords do not match.");
                    }
                    else if (passBox.Text.Length < 6 || passBox.Text.Length > 24)
                    {
                        MessageBox.Show("Passwords must be between 6 and 24 characters long.");
                    }
                    else // if details passed all validation checks
                    {
                        if (policyBox.Text == "") // handeling case where user did not enter any policy ID
                        {
                            policyBox.Text = "-1";
                        }
                        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
                        connection.Open(); // opening a new connection to the local database
                        string query = "UPDATE users SET fName=@fName, lName=@lName, email=@email, pass=@pass, address=@address, policyID=@policyID, technician=@technician, title=@title, deactivated=@deactivated, bDate=@bDate WHERE Id=@uID"; // update command
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@uId", this.uID);
                        cmd.Parameters.AddWithValue("@fName", fnBox.Text);
                        cmd.Parameters.AddWithValue("@lName", lnBox.Text);
                        cmd.Parameters.AddWithValue("@email", emailBox.Text);
                        cmd.Parameters.AddWithValue("@pass", passBox.Text);
                        cmd.Parameters.AddWithValue("@address", addressBox.Text);
                        cmd.Parameters.AddWithValue("@policyID", policyBox.Text);
                        cmd.Parameters.AddWithValue("@technician", false);
                        cmd.Parameters.AddWithValue("@title", "Customer");
                        cmd.Parameters.AddWithValue("@deactivated", deactivateCheck.Checked);
                        cmd.Parameters.AddWithValue("@bDate", datePicker.Value);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User for " + fnBox.Text + " " + lnBox.Text + " was updated succesfuly!\nReturning to login page.");
                        connection.Close(); // closing the connection after capturing the user information
                        Close();
                    }
                }
                else // field inspections in case of a technitian user creation
                {
                    if (fnBox.Text == "" || lnBox.Text == "" || emailBox.Text == "" || passBox.Text == "" || verifyBox.Text == "" || addressBox.Text == "" || DateTime.Now.Year - datePicker.Value.Year < 18 || verifyCheck.Checked == false || titleBox.Text == "")
                    {
                        MessageBox.Show("Please fill up all the mandatory fields and checks.");
                    }
                    else if (!string.Equals(passBox.Text, verifyBox.Text)) // if entered passwords do not match
                    {
                        MessageBox.Show("Passwords do not match.");
                    }
                    else if (passBox.Text.Length < 6 || passBox.Text.Length > 24)
                    {
                        MessageBox.Show("Passwords must be between 6 and 24 characters long.");
                    }
                    else // if details passed all validation checks
                    {
                        if (policyBox.Text == "") // handeling case where user did not enter any policy ID
                        {
                            policyBox.Text = "-1";
                        }
                        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
                        connection.Open(); // opening a new connection to the local database
                        string query = "UPDATE users SET fName=@fName, lName=@lName, email=@email, pass=@pass, address=@address, policyID=@policyID, technician=@technician, title=@title, deactivated=@deactivated, bDate=@bDate WHERE Id=@uID"; // update command
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@uId", this.uID);
                        cmd.Parameters.AddWithValue("@fName", fnBox.Text);
                        cmd.Parameters.AddWithValue("@lName", lnBox.Text);
                        cmd.Parameters.AddWithValue("@email", emailBox.Text);
                        cmd.Parameters.AddWithValue("@pass", passBox.Text);
                        cmd.Parameters.AddWithValue("@address", addressBox.Text);
                        cmd.Parameters.AddWithValue("@policyID", policyBox.Text);
                        cmd.Parameters.AddWithValue("@technician", technitianCheck.Checked);
                        cmd.Parameters.AddWithValue("@title", titleBox.Text);
                        cmd.Parameters.AddWithValue("@deactivated", deactivateCheck.Checked);
                        cmd.Parameters.AddWithValue("@bDate", datePicker.Value);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User for " + fnBox.Text + " " + lnBox.Text + " was updated succesfuly!\nReturning to login page.");
                        connection.Close(); // closing the connection after capturing the user information
                        Close();
                    }
                }
            }
        }

        private void passRules_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // tip message for the user
        {
            MessageBox.Show("Passwords must be between 6 and 24 characters long.\nPasswords are case sensitive.\nWe recommend using numbers, symboles, upper-case, and lower-case letters.");
        }

        private void dateRules_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // tip message for age
        {
            MessageBox.Show("Users must be at least 18 years of age");
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            ValidateDetails(); // calling the ValidateDetails method to validate and store user details.
        }

        private void deactivateCheck_CheckedChanged(object sender, EventArgs e) // this method displays a warning message to the user if they select the deactivation option, prior to making it pernament.
        {
            if (deactivateCheck.Checked == true)
            {
                MessageBox.Show("*** Warning! ***\n\nThis user will be deactivated if you proceede, and wont be accessible!\nOnly submit if you wish to deactivate your user.");
            }
        }

        public void updateUser(User tUser) // this method creates a user details form which is populated using the passed user details
        {
            formTitleLabel.Text = "Update User Details:"; // setting appropriate title
            deactivateCheck.Visible = true;
            this.update = true; // indicates that the form will be used to update instead of creating a new user
            fnBox.Text = tUser.FName;
            lnBox.Text = tUser.LName;
            emailBox.Text = tUser.Email;
            passBox.Text = tUser.Pass;
            verifyBox.Text = tUser.Pass;
            addressBox.Text = tUser.Address;
            policyBox.Text = tUser.PolicyID;
            if (policyBox.Text == "-1") // if no policy was stored
            {
                policyBox.Text = ""; // clear the policy field
            }
            datePicker.Value = tUser.BDate;
            if (tUser.Tachnitian == true)
            {
                technitianCheck.Visible = true;
                technitianCheck.Checked = tUser.Tachnitian;
                titleBox.Visible = true;
                titleBox.Text = tUser.Title;
            }
            else
            {
                technitianCheck.Visible = false;
                titleBox.Visible = false;
                titleLabel.Visible = false;
                impTitleLabel.Visible = false;
            }
            // the code below fetches the user's ID number
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
            connection.Open(); // opening a new connection to the local database
            string query = "SELECT Id FROM users WHERE email=@email AND pass=@password"; // query command
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@email", tUser.Email); // inserting user input into query
            cmd.Parameters.AddWithValue("@password", tUser.Pass); // inserting user input into query
            SqlDataReader sRead = cmd.ExecuteReader();
            sRead.Read();
            this.uID = (int)sRead.GetValue(0); // setting user ID to be used in update method
            connection.Close(); // closing the connection to free it up

        }

        private void exitButton_Click(object sender, EventArgs e) // closes the form
        {
            Close();
        }
    }
}

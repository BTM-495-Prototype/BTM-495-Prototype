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
using System.Text.RegularExpressions;

namespace BTM_495_Final_Prototype
{
    public partial class NotificationCreationDashboard : Form
    {
        public NotificationCreationDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Sets the form start position to the screen center

            // the below code block updates the user selection drop-down menu with active users
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
            connection.Open(); //opening the DB connection
            string query = "SELECT Id, fName, lName, email FROM users WHERE deactivated=0"; // return all active users
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            DataTable dTable = new DataTable();
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dTable);

            foreach (DataRow dRow in dTable.Rows) // populating the drop down menu with user information
            {
                recipientBox.Items.Add("User ID: " + dRow["Id"].ToString() + ", Name: " + dRow["fName"] + " " + dRow["lName"] + ", Email: " + dRow["email"]);
            }
            connection.Close(); // closing the connection to free it up
        }

        private void submitButton_Click(object sender, EventArgs e) // this method sends the notification details to the Notification Handler for DB storage
        {
            if (recipientBox.SelectedItem != null && categoryBox.SelectedItem != null && messageBox.Text != "") // if all fields are filled
            {
                Match match = Regex.Match((string)recipientBox.SelectedItem, @"\d+"); // isolate the user's ID from the selection using RegEx
                NotificationHandler nHandler = new NotificationHandler();
                nHandler.createNotification(int.Parse(match.Value), (string)categoryBox.SelectedItem, messageBox.Text); // calling the notification creation method from notification handler, passing the appropriate data.
                // resetting the message to allow the user to create another notification.
                messageBox.Clear();

            }
            else
            {
                MessageBox.Show("Please make all selections, and ensure the message field is full.");
            }
        }

        private void closeButton_Click(object sender, EventArgs e) // closes the form
        {
            Close();
        }
    }
}

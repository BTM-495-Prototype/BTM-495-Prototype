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
    public partial class NotificationView : Form
    {
        DataTable viewTable = new DataTable(); // declaring a new DataTable to temporaty store notifications and make them available to all class methods
        public NotificationView(int uID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Sets the form start position to the screen center
            // the code below populates the users notification selection drop down menu
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
            connection.Open(); //opening the DB connection
            string query = "SELECT * FROM notifications WHERE dismissed=0 AND uID=@uID"; // return all active users
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@uID", uID);
            cmd.ExecuteNonQuery();
            DataTable dTable = new DataTable();
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dTable);

            foreach (DataRow dRow in dTable.Rows) // populating the drop down menu with notification information
            {
                DateTime date = (DateTime)dRow["creationDate"];
                string trimmedDate = date.ToString("yyyy-MM-dd HH:mm:ss");
                notificaitonSelector.Items.Add("Message ID: " + dRow["Id"] + " | Catetory: " + dRow["category"] + " | Date: " + trimmedDate);
            }
            connection.Close(); // closing the connection to free it up
            this.viewTable = dTable; // storing the notifications in the class DataTable
        }

        private void exitButton_Click(object sender, EventArgs e) // Close the form
        {
            Close();
        }

        private void dismissButton_Click(object sender, EventArgs e) // this method indicates that the notificaiton was dismissed by the user and should not be shown again later
        {
            if (MessageBox.Show("Are you sure you want to dismiss the notification?" +
                "\nIt wont apear in your notification viewer next time you use it.",
                "Confirmation required", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // presenting a confirmation box to the user, only dismissing the notificaiton if they choose "yes"
            {
                Match match = Regex.Match((string)notificaitonSelector.SelectedItem, @"\d+"); // isolate the notification's ID from the selection using RegEx
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
                connection.Open(); //opening the DB connection
                string query = "UPDATE notifications SET dismissed=1 WHERE Id = @Id"; // update query
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", (string)match.Value);
                cmd.ExecuteNonQuery();
                connection.Close(); // Closing the connection to free it
                MessageBox.Show("Notificaiton dismissed.\nYou can still view it until you exit this tab.");
            }
        }

        private void notificaitonSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match((string)notificaitonSelector.SelectedItem, @"\d+"); // isolate the notification's ID from the selection using RegEx
            foreach (DataRow dRow in viewTable.Rows) // populating the drop down menu with user information
            {
                if (Equals(dRow["Id"].ToString(), (string)match.Value)) // comparing the notificaiton Id to the selected notification
                {
                    notificationBox.Text = dRow["message"].ToString(); // displaying the correct message
                }
            }
        }
    }
}

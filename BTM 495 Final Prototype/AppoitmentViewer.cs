using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BTM_495_Final_Prototype
{
    public partial class AppoitmentViewer : Form
    {
        DataTable viewTable = new DataTable(); // declaring a new DataTable to temporaty store notifications and make them available to all class methods
        User vUser = new User(); // local user variable to user for 
        public AppoitmentViewer(User tUser)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Sets the form start position to the screen center
            this.vUser = tUser; // capturing the user details

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
            connection.Open(); //opening the DB connection
            string query = "SELECT * FROM appointments WHERE canceled=0 AND uID=@uID"; // return all meetings scheduled meetings for a specific user
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@uID", tUser.Id);
            cmd.ExecuteNonQuery();
            DataTable dTable = new DataTable();
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dTable);

            foreach (DataRow dRow in dTable.Rows) // populating the drop down menu with notification information
            {
                DateTime date = (DateTime)dRow["date"];
                string trimmedDate = date.ToString("dd-MM-yy"); // extracting and formating appointment day

                string timeSlot = "";

                switch (dRow["timeSlot"]) // converting the time slot to string representation
                {
                    case 0:
                        timeSlot = "09:00 am";
                        break;
                    case 1:
                        timeSlot = "10:00 am";
                        break;
                    case 2:
                        timeSlot = "11:00 am";
                        break;
                    case 3:
                        timeSlot = "12:00 pm";
                        break;
                    case 4:
                        timeSlot = "13:00 pm";
                        break;
                    case 5:
                        timeSlot = "14:00 pm";
                        break;
                    case 6:
                        timeSlot = "15:00 pm";
                        break;
                    case 7:
                        timeSlot = "16:00 pm";
                        break;
                    case 8:
                        timeSlot = "17:00 pm";
                        break;
                    default:
                        break;
                }

                if (date < DateTime.Today) // seeing if the appointment has passed by day value
                {
                    appBox.Items.Add("ID: " + dRow["Id"].ToString() + " | This appointment passed | Appointment time (dd-mm-yy): " + trimmedDate + " " + timeSlot); // populating the users drop down menu with non cancled meetings
                }
                else
                {
                    appBox.Items.Add("ID: " + dRow["Id"].ToString() + " | Appointment time (dd-mm-yy): " + trimmedDate + " " + timeSlot); // populating the users drop down menu with non cancled meetings
                }
            }
            connection.Close(); // closing the connection to free it up
            this.viewTable = dTable; // storing the notifications in the class DataTable

        }

        private void button1_Click(object sender, EventArgs e) // this method closes the form
        {
            Close();
        }

        private void appBox_SelectedIndexChanged(object sender, EventArgs e) // this method will populate the informaiton table using 
        {
            Match match = Regex.Match((string)appBox.SelectedItem, @"\d+"); // isolate the appoitments's ID from the selection using RegEx
            foreach (DataRow dRow in viewTable.Rows) // populating the drop down menu with user information
            {
                if (Equals(dRow["Id"].ToString(), (string)match.Value)) // comparing the notificaiton Id to the selected appointment's
                {
                    infoBox.Text = "Appoitment type: " + dRow["type"].ToString() + "" +
                        "\n\nPlease make sure to bring your prescription if needed."; // displaying the correct message
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) // this method marks an appoitment as cancled, users can use this to cancel appoitments or dismiss old appoitments
        {
            if (MessageBox.Show("Are you sure you want to dismiss this appointment?" +
                "\nIt wont apear in your appointment viewer next time you use it.",
                "Confirmation required", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // presenting a confirmation box to the user, only dismissing the notificaiton if they choose "yes"
            {
                Match match = Regex.Match((string)appBox.SelectedItem, @"\d+"); // isolate the notification's ID from the selection using RegEx
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
                connection.Open(); //opening the DB connection
                string query = "UPDATE appointments SET canceled=1 WHERE Id = @Id"; // update query
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", (string)match.Value);
                cmd.ExecuteNonQuery();
                connection.Close(); // Closing the connection to free it
                MessageBox.Show("Appointment dismissed.\nYou can still view it until you exit this tab.");
            }
        }

        private void appTip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Appoitments are ordered by creation time.\nThe latest appointment made will be shown last.");
        }
    }
}

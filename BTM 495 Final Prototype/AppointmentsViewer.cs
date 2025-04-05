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

namespace BTM_495_Final_Prototype
{
    public partial class AppointmentsViewer : Form
    {
        public AppointmentsViewer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Sets the form start position to the screen center

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
            connection.Open(); //opening the DB connection
            string query = "SELECT * FROM appointments"; // return all meetings
            SqlCommand cmd = new SqlCommand(query, connection);
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
                    appBox.Text = (appBox.Text + "ID: " + dRow["Id"].ToString() + " | This appointment passed | Appointment time (dd-mm-yy): " + trimmedDate + " " + timeSlot + " | Type: " + dRow["type"] + " | Customer: " + dRow["name"] + " | Cancled/dismissed: " + dRow["canceled"] + "\n\n"); // populating the users drop down menu with non cancled meetings
                }
                else
                {
                    appBox.Text = (appBox.Text + "ID: " + dRow["Id"].ToString() + " | Appointment time (dd-mm-yy): " + trimmedDate + " " + timeSlot + " | Type: " + dRow["type"] + " | Customer: " + dRow["name"] + " | Cancled/dismissed: " + dRow["canceled"] + "\n\n"); // populating the users drop down menu with non cancled meetings
                }
            }
            connection.Close(); // closing the connection to free it up
        }

        private void exitButton_Click(object sender, EventArgs e) // this method closes the form
        {
            Close();
        }
    }
}

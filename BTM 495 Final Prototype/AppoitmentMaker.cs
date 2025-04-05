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
    public partial class AppoitmentMaker : Form
    {
        User appUser = new User(); // creating a new user to be used by the class methods
        public AppoitmentMaker(User tUser)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Sets the form start position to the screen center
            datePicker.MinDate = DateTime.Today.AddDays(1); // setting minumum and maximum dates available for selection
            datePicker.MaxDate = DateTime.Today.AddMonths(1);
            this.appUser = tUser; // capturing the details of the passed user

            if (datePicker.MinDate.DayOfWeek == DayOfWeek.Sunday) //if tomorrow is a weekend day
            {
                datePicker.MinDate = DateTime.Today.AddDays(2);
            }
            else if (datePicker.MinDate.DayOfWeek == DayOfWeek.Saturday)
            {
                datePicker.MinDate = DateTime.Today.AddDays(3);
            }

            datePicker.Value = datePicker.MinDate; // setting the picked value to automatically be the closest allowed
        }

        private void dateTip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The pharmacy is open for appoitments Monday-Friday." +
                "\nAppoitments are available as early as the following day, and as late as a month in advance.");
        }

        private void datePicker_ValueChanged(object sender, EventArgs e) // this method runs everytime the picked date changes
        {
            if (datePicker.Value.DayOfWeek == DayOfWeek.Saturday || datePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                // showing the user an appropriate error message and resetting the date selection
                MessageBox.Show("The pharmacy is open for appoitments Monday-Friday." +
                "\nAppoitments are available as early as the following day, and as late as a month in advance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datePicker.Value = datePicker.MinDate;
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
                connection.Open(); // opening a new connection to the local database
                string query = "SELECT * FROM appointments WHERE date=@date AND canceled=0"; // querying the schedueled meetings for the day
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@date", datePicker.Value.AddMicroseconds(-datePicker.Value.Microsecond)); // working solly on day percision
                cmd.ExecuteNonQuery();
                DataTable dTable = new DataTable();
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                dAdapter.Fill(dTable); // storing result in data table for inspection
                connection.Close(); // closing teh connection to frre it up

                foreach (DataRow dRow in dTable.Rows)
                {
                    slotBox.Items[(int)dRow["timeSlot"]] = "-Taken-";
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e) // this method closes the form
        {
            Close();
        }

        private void makeApp_Click(object sender, EventArgs e)
        {
            // valdiation checks to ensure all selections were made
            if (slotBox.SelectedIndex == -1 || typeBox.SelectedIndex == -1 || slotBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please ensure all fields are full.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (slotBox.Items[slotBox.SelectedIndex].Equals("-Taken-")) // valdiation check to ensure an avaialble time slot was choosen
            {
                MessageBox.Show("Please select a free time slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
                connection.Open(); // opening a new connection to the local database
                string query = "INSERT INTO appointments (date, timeSlot, uID, name, type) VALUES (@date, @timeSlot, @uID, @name, @type)"; // insertion query
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@date", datePicker.Value.AddMicroseconds(-datePicker.Value.Microsecond)); // date at day precision
                cmd.Parameters.AddWithValue("@timeSlot", (int)slotBox.SelectedIndex);
                cmd.Parameters.AddWithValue("@uID", appUser.Id);
                cmd.Parameters.AddWithValue("@name", appUser.FName + " " + appUser.LName);
                cmd.Parameters.AddWithValue("@type", (string)typeBox.SelectedItem);
                cmd.ExecuteNonQuery();
                connection.Close(); // closing conneciton to free it up
                MessageBox.Show("Appointment placed.");
                Close(); // closing the appoitment planner
            }
        }

        private void slotBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

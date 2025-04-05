using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BTM_495_Final_Prototype
{
    public partial class PlaceOrder : Form
    {
        User orderUser = new User(); // declaring local user object to be used further in methods
        public PlaceOrder(User tUser)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Sets the form start position to the screen center
            this.orderUser = tUser; // setting the value of the local user attribute
            totalBox.Text = "0";
        }

        private void itemTip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // showing informaiton regarding item availability to the user
        {
            MessageBox.Show("Some items are not avaialble to order online.\nIf the item you wish to order isnt on the list, please contact us directly for inquery." +
                "To call or leave a voice message: (514) - 123 4567" +
                        "\n\tTo leave an email: Pharmacy@Pharmacy.com" +
                        "\n\nOne of our team members will reach back to help you resolve your issues as soon as possible." +
                        "\n\nOur work hours:" +
                        "\n\tMonday-Friday: 08:00-18:00" +
                        "\n\tSaturday-Sunday: 10:00-14:00" +
                        "\n\tHolidays: tentative" +
                        "\n\tAddress: Rue Pharmacy 1, QC, MTL.");
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeBox.SelectedIndex == 0)
            {
                itemBox.Items.Clear();
                itemBox.Items.Add("Medicine a: 10$");
                itemBox.Items.Add("Medicine b: 20$");
                itemBox.Items.Add("Medicine c: 15$");
                itemBox.Items.Add("Medicine d: 10$");
                itemBox.Items.Add("Medicine e: 20$");
                itemBox.Items.Add("Medicine f: 15$");
            }
            else if (typeBox.SelectedIndex == 1)
            {
                itemBox.Items.Clear();
                itemBox.Items.Add("Device a: 20$");
                itemBox.Items.Add("Device b: 30$");
                itemBox.Items.Add("Device c: 40$");
                itemBox.Items.Add("Device d: 20$");
                itemBox.Items.Add("Device e: 30$");
                itemBox.Items.Add("Device f: 40$");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (itemBox.SelectedIndex == -1) // case where user did not select an item to add
            {
                MessageBox.Show("No item selected");
            }
            else
            {
                cartBox.Text = (cartBox.Text + itemBox.SelectedItem.ToString() + "\n");
                Match match = Regex.Match((string)itemBox.SelectedItem, @"\d+"); // isolate the item cost from the selection using RegEx

                int total = int.Parse(totalBox.Text) + int.Parse(match.Value);
                totalBox.Text = total.ToString(); // update total ammount with addition of new items
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            cartBox.Clear(); // empthy the cart box
            totalBox.Text = "0";
        }

        private void exitButton_Click(object sender, EventArgs e) // this method closes the order window
        {
            Close();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (cartBox.Text == "") // case user pressed the order button with an empty cart
            {
                MessageBox.Show("Can't place an empty order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
                connection.Open(); //opening the DB connection
                string query = "INSERT INTO orders (uID, items, datePlaced, total) VALUES (@uID, @items, @datePlaced, @total)"; // insertion command 
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@uID", orderUser.Id);
                cmd.Parameters.AddWithValue("items", cartBox.Text);
                cmd.Parameters.AddWithValue("datePlaced", DateTime.Today);
                cmd.Parameters.AddWithValue("@total", int.Parse(totalBox.Text));
                cmd.ExecuteNonQuery(); // executing command

                query = "INSERT INTO notifications (uID, category, message, creationDate) VALUES (@uID, 'Order Details', @message, @creationDate)"; // insertion command into notifications
                cmd = new SqlCommand(query, connection); // initializing new command
                cmd.Parameters.AddWithValue("@uID", orderUser.Id);
                cmd.Parameters.AddWithValue("message", "Date Placed: " + DateTime.Today.ToString() + "\n\nOrdered Items: \n" + cartBox.Text + "\nOrder Total: " + totalBox.Text + "$\n\nAn update notification will be sent to you when it is ready.");
                cmd.Parameters.AddWithValue("@creationDate", DateTime.Today);
                cmd.ExecuteNonQuery(); // executing command
                connection.Close(); // closing connection to free it 
                MessageBox.Show("The order was placed in our system!\nA notification with the order's details has been sent to you.\nReturning to dashboard."); // notifying user
                Close(); // closing order form
            }
        }
    }
}

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
    public partial class OrderViewer : Form
    {
        DataTable viewTable = new DataTable(); // declaring local DataTable to maintain orders
        int oID = -1; // holding the ID value of the selected order
        public OrderViewer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Sets the form start position to the screen center
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
            connection.Open(); //opening the DB connection
            string query = "SELECT * FROM orders WHERE canceled=0 AND fulfilled=0"; // return all orders that are not fulfilled or canceled
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            DataTable dTable = new DataTable();
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dTable);
            connection.Close(); // closing the connection to free it

            foreach (DataRow dRow in dTable.Rows) // populating the drop down menu with notification information
            {
                connection.Open(); // opening new connection
                string uName = ""; // the code block below retrives the suer name using thier ID
                query = "SELECT fName, lName FROM users WHERE Id=@uID";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@uID", dRow["uID"]);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                uName = reader["fName"].ToString() + " " + reader["lName"].ToString();

                orderBox.Items.Add("Order ID: " + dRow["Id"] + " | " + "Placed: " + dRow["datePlaced"] + " | " + uName);

                connection.Close(); // closing connection to free it
            }

            this.viewTable = dTable; // capturing returned values
        }

        private void orderBox_SelectedIndexChanged(object sender, EventArgs e) // this method handels changing the selections in the drop down menue, loading the correct order details
        {
            Match match = Regex.Match((string)orderBox.SelectedItem, @"\d+"); // isolate the order's ID from the selection using RegEx
            foreach (DataRow dRow in viewTable.Rows) // populating the drop down menu with user information
            {
                if (Equals(dRow["Id"].ToString(), (string)match.Value)) // comparing the notificaiton Id to the selected appointment's
                {
                    orderDetailsBox.Text = "Order ID: " + dRow["Id"].ToString()
                        + "\n\nDate Placed: " + dRow["datePlaced"]
                        + "\n\nOrdered Items:\n" + dRow["items"]
                        + "\nOrder Total: " + dRow["total"] + "$"; // displaying order info
                    this.oID = (int)dRow["Id"];
                }
            }
        }

        private void exitBottun_Click(object sender, EventArgs e)
        {
            Close(); // this method closes the viewer
        }

        private void fulfilledButton_Click(object sender, EventArgs e) // this method markes the order as fulfilled
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
            connection.Open(); //opening the DB connection
            string query = "UPDATE orders SET fulfilled=1 WHERE Id=@Id"; // update command
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", oID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order was marked as fulfilled.\nYou can still view it until reloading the page.");

        }

        private void canceledButton_Click(object sender, EventArgs e) // this method markes the order as canceled
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
            connection.Open(); //opening the DB connection
            string query = "UPDATE orders SET canceled=1 WHERE Id=@Id"; // update command
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", oID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order was marked as canceled.\nYou can still view it until reloading the page.");

        }
    }
}

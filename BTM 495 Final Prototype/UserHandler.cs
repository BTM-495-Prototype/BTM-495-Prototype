using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BTM_495_Final_Prototype
{
    public class UserHandler
    {
    public bool authenticate(string email, string pass) // this method handles user authentications
        {

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
            connection.Open(); // opening a new connection to the local database
            string query = "SELECT count(*) FROM users WHERE email=@email AND pass=@password AND deactivated=0"; // quary to see if there are any active users that match the password and email combonation
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@email", email); // inserting user input into query
            cmd.Parameters.AddWithValue("@password", pass); // inserting user input into query
            int count = (int)cmd.ExecuteScalar(); // counter variable to see if there are any matches
            connection.Close(); // closing the connection to the local db to free it

            if (count > 0)
            {
                MessageBox.Show("Authentication successful!\nMoving to user dashboard.");
                return true;
            }
            else MessageBox.Show("Wrong email and/or password.\nPlease try again.");

            return false; // returning outcome message to caller
        }

    public void dashboard(string email, string pass) // this method generates the appropriate user dashboard based on user identification
        {
            User tUser = new User(); // temporaty user object 
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
            connection.Open(); // opening a new connection to the local database
            string query = "SELECT * FROM users WHERE email=@email AND pass=@password"; // quary to retrive all data from the appropriate record
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@email", email); // inserting user input into query
            cmd.Parameters.AddWithValue("@password", pass); // inserting user input into query
            SqlDataReader sRead = cmd.ExecuteReader();
            while (sRead.Read()) // this will loop until all data in the appropriate row was processed
            {
                tUser.Id = (int)sRead.GetValue(0);
                tUser.FName = (string)sRead.GetValue(1);
                tUser.LName = (string)sRead.GetValue(2);
                tUser.Email = (string)sRead.GetValue(3);
                tUser.Pass = (string)sRead.GetValue(4);
                tUser.Address = (string)sRead.GetValue(5);
                tUser.PolicyID = (string)sRead.GetValue(6);
                tUser.Tachnitian = (bool)sRead.GetValue(7);
                tUser.Title = (string)sRead.GetValue(8);
                tUser.Deactivated = (bool)sRead.GetValue(9);
                tUser.BDate = (DateTime)sRead.GetValue(10);
            }
            connection.Close(); // closing the db connection to free it up
            Dashdoard dash = new Dashdoard();
            dash.GenerateDashboard(tUser); 
            dash.Show();
        }

    } 
}


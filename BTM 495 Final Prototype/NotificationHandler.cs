using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BTM_495_Final_Prototype
{
    class NotificationHandler
    {

        public void createNotification(int uID, string category, string message) // this method creates a new notification for a user
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\DANKA\\DESKTOP\\SCHOOL\\CLASSES\\BTM 495\\PROTOTYPES\\BTM 495 FINAL PROTOTYPE\\PROTOTYPE DATABASE.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); // conneciton string to local DB instance for the solution
            connection.Open(); //opening the DB connection
            string query = "INSERT INTO notifications (uID, category, message, creationDate) VALUES (@uID, @category, @message, @date)"; // insertion command
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@uId", uID);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@message", message);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.ExecuteNonQuery();
            connection.Close(); // closing connection
            MessageBox.Show("Notification was created!");
        }

    }
}

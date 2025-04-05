using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM_495_Final_Prototype
{
    public class User
    { // default attributes of the user object
        private int id = -1;
        private string fName = "", lName = "", email = "", pass = "", address = "", policyID = "", title = "";
        private bool deactivated = false, tachnitian = false;
        private DateTime bDate = new DateTime();

        public User() // default constructor
        {

        }
        public User(int id, string fName, string lName, string email, string pass, string address, string policyID, bool tecnitian, string title, bool deactivated, DateTime bDate) // constructor
        {
            this.Id = id;
            this.FName = fName;
            this.LName = lName;
            this.Email = email;
            this.Pass = pass;
            this.Address = address;
            this.PolicyID = policyID;
            this.Tachnitian = tecnitian;
            this.Title = title;
            this.Deactivated = deactivated;
            this.BDate = bDate;
        }

        // get and set methods
        public int Id { get => id; set => id = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Email { get => email; set => email = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Address { get => address; set => address = value; }
        public string PolicyID { get => policyID; set => policyID = value; }
        public string Title { get => title; set => title = value; }
        public bool Deactivated { get => deactivated; set => deactivated = value; }
        public bool Tachnitian { get => tachnitian; set => tachnitian = value; }
        public DateTime BDate { get => bDate; set => bDate = value; }

        public string ToString()
        {
            return (fName + ", " + lName);
        }
    } 
}

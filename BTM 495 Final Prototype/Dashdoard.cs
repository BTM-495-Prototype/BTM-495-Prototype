using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTM_495_Final_Prototype
{
    public partial class Dashdoard : Form
    {
        User dashUser = new User();
        public Dashdoard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Sets the form start position to the screen center
            clockBox.Enabled = false; // making the clock non-interactable by the user
        }

        public void GenerateDashboard(User tUser) // this method generates the appropriate dashboard for the user, based on its attributes
        {
            this.dashUser = tUser; // appending the passed used to the form's local variable, to be further used in other methods and funcitons
            WelcomeLabel.Text = "Welcome " + this.dashUser.FName + " " + this.dashUser.LName.Substring(0, 1) + ". !";
            if (tUser.Tachnitian == false) // removing featues that are technician only
            {
                cNoteButton.Visible = false;
                cUserButton.Visible = false;
                ordsViewbutton.Visible = false;
                appsViewButton.Visible = false;
            }
            else // removing features that are not relevant for technicians
            {
                mOrdButton.Visible = false;
                cAppButton.Visible = false;
                mAppButton.Visible = false;
            }
        }

        private void dashClock_Tick(object sender, EventArgs e) // this method updates the dashboard clock using the form's timer element.
        {
            clockBox.Text = DateTime.Now.ToString();
        }

        private void cUserButton_Click(object sender, EventArgs e) // this method creates a user creating form for a new technitian user, can also be used to create normal users manually
        {
            DetailsForm details = new DetailsForm();
            details.CreateTechnician();
            details.Show();
        }

        private void upUserButton_Click(object sender, EventArgs e) // this method creates a user details form that is populated with thge current user details, allowing the user to update thier details
        {
            DetailsForm details = new DetailsForm();
            details.updateUser(dashUser);
            details.Show();
            Close();
        }

        private void fButton_Click(object sender, EventArgs e)
        {
            FaqForm faq = new FaqForm();
            faq.Show();
        }

        private void cNoteButton_Click(object sender, EventArgs e) // this method creates the notification creation dashboard when a user clicks the appropriate button
        {
            NotificationCreationDashboard cnDash = new NotificationCreationDashboard();
            cnDash.Show();
        }

        private void rNoteButton_Click(object sender, EventArgs e) // this methods creates the notificaiton viewer for the specific user
        {
            NotificationView nView = new NotificationView(dashUser.Id); // passing the userID to the notificaiton viewer board
            nView.Show();
        }

        private void mAppButton_Click(object sender, EventArgs e) //this method creates a new appoitment making dashboard when the appropriate button is clicked
        {
            AppoitmentMaker appDash = new AppoitmentMaker(dashUser);
            appDash.Show();
        }

        private void cAppButton_Click(object sender, EventArgs e)
        {
            AppoitmentViewer appView = new AppoitmentViewer(dashUser);
            appView.Show();
        }

        private void exitButton_Click(object sender, EventArgs e) // this method closes the dashboard
        {
            Close();
        }

        private void appsViewButton_Click(object sender, EventArgs e) // this method opens the appointment viewer dashboard for technitians, showing all appointments
        {
            AppointmentsViewer appsView = new AppointmentsViewer();
            appsView.Show();
        }

        private void mOrdButton_Click(object sender, EventArgs e) // this method calls the order placing dashboard
        {
            PlaceOrder pOrder = new PlaceOrder(dashUser);
            pOrder.Show();
        }

        private void ordsViewbutton_Click(object sender, EventArgs e) // this method calls the order viewing dashboard for technitians
        {
            OrderViewer oView = new OrderViewer();
            oView.Show();
        }
    }
}

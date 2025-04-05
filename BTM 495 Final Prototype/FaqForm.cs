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
    public partial class FaqForm : Form
    {
        public FaqForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Sets the form start position to the screen center
            answerBox.Text = "Please select a topic from the above selection."; // initializing text instructions for the user
            fawComboBox.Text = "F.A.Q topics";
        }

        private void button1_Click(object sender, EventArgs e) // this event closes the FAW screen
        {
            Close();
        }

        private void fawComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (fawComboBox.SelectedIndex){
                case 0:
                    answerBox.Text = "Steps to make a new appointment:" +
                        "\n\t1. Navigate to your user dashboard." +
                        "\n\t2. Locate the \"Make new appointment\" button." +
                        "\n\t3. Click the button, the appointment making tab will open." +
                        "\n\t4. Fill in the requested information, as indicated." +
                        "\n\t5. Press \"Create appointment\"." +
                        "\n\t6. A new appointment was created in the system." +
                        "\n\n" +
                        "To view or cancel your appoitment: " +
                        "\n\t1. Navigate to your user dashdoard, and select \"View or Cancel Appoitment\"." +
                        "\n\t2. All appoitments that are related to your account will now be displayed." +
                        "\n\t3. Select \"Cancle\" next to an appointment to cancle it." +
                        "\n\t4. Press \"Confirm\" to confirm your actions.";
                    break;
                case 1:
                    answerBox.Text ="Steps to place a new order:" +
                        "\n\t1. Navigate to your user dashboard." +
                        "\n\t2. Locate the \"Place New Order\" button." +
                        "\n\t3. Click the button, the order placing tab will open." +
                        "\n\t4. Fill in the requested information, as indicated." +
                        "\n\t5. Press \"Place Order\"." +
                        "\n\t6. A new order was created in the system." +
                        "\n\n" +
                        "To view or cancel your order: " +
                        "\n\t1. Navigate to your user dashdoard, and select \"View or Cancel Order\"." +
                        "\n\t2. All orders that are related to your account will now be displayed." +
                        "\n\t3. Select \"Cancle\" next to an order to cancle it." +
                        "\n\t4. Press \"Confirm\" to confirm your actions.";
                    break;
                case 2:
                    answerBox.Text = "To deactivate your user:" +
                        "\n\t1. Navigate to your user dashboard." +
                        "\n\t2. Locate the \"Modify User\" button." +
                        "\n\t3. A new tab will open, this tab will allow you to update any and all user details." +
                        "\n\t4. The informaiton fields will be populated with your current information." +
                        "\n\t5. Update any fields you wish, as specified." +
                        "\n\t6. When ready, verify your information and selections." +
                        "\n\t7. Press \"Submit\"." +
                        "\n\t8. A message will be displayed, and you will be loged our of the system." +
                        "\n\t9. You can now access your acocunt again with the new details.";
                    break;
                case 3:
                    answerBox.Text = "To deactivate your user:" +
                        "\n\t1. Navigate to your user dashboard." +
                        "\n\t2. Locate the \"Modify User\" button." +
                        "\n\t3. A new tab will open, this tab will allow you to update any and all user details." +
                        "\n\t4. At the bottom right, select \"Deactivate ny account\"." +
                        "\n\t5. A warning message will be displayed." +
                        "\n\t6. Verify your details and selection, and press \"Submit\"." +
                        "\n\t7. Your account is now deactivated, and you wont be able to access it again." +
                        "\n" +
                        "\nNote: If you wish to reactivate the account, or erase its data from our database, please contact us through Pharmacy@Pharmacy.com with your request.";
                    break;
                case 4:
                    answerBox.Text = "To retrive your user details, please contact us directly so that the user could be recovered." +
                        "\n\nContact Information:" +
                        "\n\tTo call or leave a voice message: (514) - 123 4567" +
                        "\n\tTo leave an email: Pharmacy@Pharmacy.com" +
                        "\n\nOne of our team members will reach back to help you resolve your issues as soon as possible." +
                        "\n\nOur work hours:" +
                        "\n\tMonday-Friday: 08:00-18:00" +
                        "\n\tSaturday-Sunday: 10:00-14:00" +
                        "\n\tHolidays: tentative" +
                        "\n\tAddress: Rue Pharmacy 1, QC, MTL.";
                    break;
                case 5:
                    answerBox.Text = "Steps to create a new user:" +
                        "\n\t1. In the login tab, select \"I don't have a user (register)\"" +
                        "\n\t2. The user registration form will open." +
                        "\n\t3. Fill in the user details and checks, as specified in the form." +
                        "\n\t4. Verify your details." +
                        "\n\t5. Press the \"Submit\" button." +
                        "\n\t6. A new user has been created, you will be returned to the login page" +
                        "\n\t7. You can now use the user you created.";
                    break;
                case 6:
                    answerBox.Text = "If your issue or question was not addressed by this F.A.Q, please do not hasitate to contact us." +
                        "\n\nContact Information:" +
                        "\n\tTo call or leave a voice message: (514) - 123 4567" +
                        "\n\tTo leave an email: Pharmacy@Pharmacy.com" +
                        "\n\nOne of our team members will reach back to help you resolve your issues as soon as possible." +
                        "\n\nOur work hours:" +
                        "\n\tMonday-Friday: 08:00-18:00" +
                        "\n\tSaturday-Sunday: 10:00-14:00" +
                        "\n\tHolidays: tentative" +
                        "\n\tAddress: Rue Pharmacy 1, QC, MTL.";
                    break;
                default:
                    answerBox.Text = "Please select a topic from the above selection.";
                    break;

            }
        }
    }
}

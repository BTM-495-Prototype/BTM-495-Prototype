using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM_495_Prototype
{
    internal class UserDataForm
    {

        private int userID = -1, employeeID = -1;
        private string userName = "", userPass = "", userEmail = "", userAddress = "", pickupAddress = "", payMethod = "", role = "";
        private DateTime userBirth = new DateTime();
        private List<InsurancePolicy> insurancePolicieList = new List<InsurancePolicy>();
        private bool isTechnician = false;

    }
}

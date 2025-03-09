using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM_495_Prototype
{
    internal class Customer : User
    {

        private int customerID = -1;
        private List<InsurancePolicy> insurancePolicyList = new List<InsurancePolicy>();
        private string pickupAddress = "", payMethod = "";
        private bool acceptsEmails = false, acceptsSMS = false;

    }
}

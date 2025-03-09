using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM_495_Prototype
{
    internal class Order
    {

        private int orderID = -1;
        private DateTime orderDate = new DateTime();
        private int userID = -1;
        private string status = "";
        private bool pickup = false;
        private bool payNow = false;
        private List<Medicine> content = new List<Medicine>();
        private double sum = -1;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Project
{
    class Residential : Customers
    {
        string homePhone;
        string neighborHood;
        string customerID;

        public Residential(string firstName, string lastName, string middleName, string address1, string adresss2, string city, string state, string zip, string homePhone,
            string neighborHood, string customerID)
            : base(firstName, lastName, middleName, address1, adresss2, city, state, zip)
        {
            this.HomePhone = homePhone;
            this.NeighborHood = neighborHood;
            this.CustomerID = customerID;
        }

        public override string displayInfo(string sep) =>
            base.displayInfo(sep) + "\n" + this.homePhone + "\n" + this.neighborHood + "\n" + "Customer ID: " + this.customerID;
        
        public string HomePhone { get => homePhone; set => homePhone = value; }
        public string NeighborHood { get => neighborHood; set => neighborHood = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
    }
}

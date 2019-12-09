using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Project
{
    class Government : Customers
    {
        string department;
        string contractNumber;
        string governmentID;

        public Government(string firstName, string lastName, string middleName, string address1, string adresss2, string city, string state, string zip, string contractnumber,
            string governmentID, string department)
            : base(firstName, lastName, middleName, address1, adresss2, city, state, zip)
        {
            this.Department = department;
            this.ContractNumber = contractNumber;
            this.GovernmentID = governmentID;
        }

        public override string displayInfo(string sep) =>
            base.displayInfo(sep) + "\n" + this.department + "\n" + "Contract Number: " + this.contractNumber + "\n" + "Government ID: " + this.governmentID + ")";

        public string Department { get => department; set => department = value; }
        public string ContractNumber { get => contractNumber; set => contractNumber = value; }
        public string GovernmentID { get => governmentID; set => governmentID = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Project
{
    class Commercial : Customers
    {
        string businessName;
        string businessPhone;
        string EDICode;

        public Commercial(string firstName, string lastName, string middleName, string address1, string adresss2, string city, string state, string zip, string businessName, 
            string businessPhone, string EDICode)
            : base(firstName, lastName, middleName, address1, adresss2, city, state, zip)
        {
            this.BusinessName = businessName;
            this.BusinessPhone = businessPhone;
            this.EDICode1 = EDICode;
        }

        public override string displayInfo(string sep) =>
            base.displayInfo(sep) + "\n" + "Business Name: " + this.businessName + "\n" + "Business Phone: " + this.businessPhone + "\n" + "EDI Code: " + this.EDICode + ")";

        public string BusinessName { get => businessName; set => businessName = value; }
        public string BusinessPhone { get => businessPhone; set => businessPhone = value; }
        public string EDICode1 { get => EDICode; set => EDICode = value; }
    }
}

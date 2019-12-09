using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Project
{
    public abstract class Customers
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private string address1;
        private string address2;
        private string city;
        private string state;
        private string zip;

        protected Customers(string firstName, string lastName, string middleName, string address1, string adresss2, string city, string state, string zip)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.address1 = address1;
            this.address2 = adresss2;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }

        public virtual string displayInfo(string sep) =>
            firstName + sep + middleName + sep + lastName + "\n" + address1 + address2 + "\n" + city + sep + state + sep + zip;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string Address1 { get => address1; set => address1 = value; }
        public string Adresss2 { get => address2; set => address2 = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2
{
    public class Customer2
    {
        private String firstName;
        private String lastName;
        private String phone;
        private String email;
        private String address;
        private String city;
        private String state;
        private int zip { get; set; }
        private int serviceID { get; set; }
        private int customerID { get; set; }

        //constructors
        public Customer2(String fn, string ln, string phone, string email, string add, string city, string state, int zip, int servID, int custID)
  
        {
            this.firstName = fn;
            this.lastName = ln;
            this.email = email;
            this.address = add;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.serviceID = servID;
            this.customerID = custID;
        }

        //methods (getters and setters) aka properties
        //properties handle get and set abilities
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models
{
    public class Student
    {
        long id;
        string firstname;
        string lastname;
        short age;
        string phoneNumber;
        string email;
        string area;
        string street;
        short address;

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set {
                if (!value.Contains("//d+"))
                {
                    this.firstname = value;
                }
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                if (!value.Contains("//d+"))
                {
                    this.lastname = value;
                }
            }
        }

        public short Age{get; set;}

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Area { get; set; }
        public string Street { get; set; }
        public string Address { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Greeting
{

    public enum Type { current, past, potential }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public Type CustomerType { get; set; }

        //empty constructor
        public Customer() { }


        public Customer(string firstName, string lastName, string email, int phoneNumber, Type customerType)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            CustomerType = customerType;
        }
    }

}




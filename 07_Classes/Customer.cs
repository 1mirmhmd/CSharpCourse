﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes
{
    internal class Customer
    {
        // Field
        //public string FirstName;

        // Property
        public int Id { get; set; }
        private string _firstName;
        public string FirstName
        {
            get
            {
                return "Mr. " + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        // Auto Property
        public string LastName { get; set; }
        public string City { get; set; }

    }
}

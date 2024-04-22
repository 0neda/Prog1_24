using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> Addressess { get; set; }

        public Customer()
        {
            
        }

        public Customer(int id)
        {
            CustomerId = id;
        }
    }
}
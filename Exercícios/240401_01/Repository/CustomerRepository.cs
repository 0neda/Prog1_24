using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Data;
using _240401_01.Models;

namespace _240401_01.Repository
{
    public class CustomerRepository
    {
        private void Save (Customer customer)
        {
            DataSet.Customers.Add(customer);
        }

        private Customer Retrieve(int id)
        {
            foreach (var c in DataSet.Customers)
            {
                if (c.CustomerId == id)
                    return c;
            }
            
            return null;
        }

        public List<Customer> Retrieve()
        {
            return DataSet.Customers;
        }
    }
}
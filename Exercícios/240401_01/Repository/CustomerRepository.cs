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

        public void Save(Customer customer, bool autoGenerateId = true)
        {
            if(autoGenerateId)
                customer.CustomerId = this.GetNextId();
            DataSet.Customers.Add(customer);
        }

        public Customer Retrieve(int id)
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

        public List<Customer> RetrieveByName(string name)
        {
            List<Customer> retorno = new List<Customer>();
            foreach (var c in DataSet.Customers)
            {
                if (c.Name.Contains(name))
                {
                    retorno.Add(c);
                }
            }
            return retorno;
        }

        public void Delete (int id)
        {
            for (int i = 0; i < DataSet.Customers.Count -1; i++)
            {
                if (DataSet.Customers[i].CustomerId == id)
                {
                    DataSet.Customers.RemoveAt(i);
                    Console.WriteLine($"Consumidor ID[{id}] deletado.");
                }
                else
                    Console.WriteLine($"Falha ao deletar Consumidor ID [{id}].");
            }
        }

        public bool ImportFromTxt(string line, string delimiter)
        {
            if(string.IsNullOrWhiteSpace(line))
                return false;

            string[] data = line.Split(delimiter);

            if(data.Count() < 1)
                return false;

            Customer c = new Customer{
                CustomerId = Convert.ToInt32(data[0] == null ? 0 : data[0]),
                Name = data[1] == null ? string.Empty : data[1], // if ternário
                EmailAddress = data[2] ?? string.Empty // checando, caso nulo substitui por string vazia
            };
            Save(c, false);
            return true;
        }

        private int GetNextId()
        {
            int n = 0;
            foreach (var c in DataSet.Customers)
            {
                if(c.CustomerId > n)
                    n = c.CustomerId;
            }

            return ++n;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Data;
using _240401_01.Models;

namespace _240401_01.Repository
{
    public class AddressRepository
    {
        private void Save (Address address)
        {
            DataSet.Addresses.Add(address);
        }

        private Address Retrieve(int id)
        {
            foreach (var a in DataSet.Addresses)
            {
                if (a.Id == id)
                    return a;
            }
            
            return null;
        }
    }
}
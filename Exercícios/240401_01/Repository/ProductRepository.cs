using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Data;
using _240401_01.Models;

namespace _240401_01.Repository
{
    public class ProductRepository
    {
        private void Save (Product product)
        {
            DataSet.Products.Add(product);
        }

        private Product Retrieve(int id)
        {
            foreach (var prod in DataSet.Products)
            {
                if (prod.Id == id)
                    return prod;
            }
            
            return null;
        }

        public bool Validate()
        {
            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Data;
using _240401_01.Models;

namespace _240401_01.Repository
{
    public class OrderRepository
    {
        private void Save (Order order)
        {
            DataSet.Orders.Add(order);
        }

        private Order Retrieve(int id)
        {
            foreach (var order in DataSet.Orders)
            {
                if (order.Id == id)
                    return order;
            }
            
            return null;
        }

        public bool Validate()
        {
            return true;
        }
    }
}
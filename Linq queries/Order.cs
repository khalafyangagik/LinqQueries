using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_queries
{
    enum OrderStatus { Pending, OnTheWay, Deliveried, PaymentRejected };
    class Order
    {
        public int Id { get; set; }
        public int userId { get; set; }

        public OrderStatus Status { get; set; }

        public Order(int id, int userId, OrderStatus status)
        {
            this.Id = id;
            this.userId = userId;
            this.Status = status;
        }


    }
}

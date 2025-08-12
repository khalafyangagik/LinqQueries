using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_queries
{
    class OrderDetails
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public int productId { get; set; }

        public int count { get; set; }

        public OrderDetails(int id, int orderId, int productId, int count)
        {
            this.Id = id;
            this.orderId = orderId;
            this.productId = productId;
            this.count = count;
        }


    }
}

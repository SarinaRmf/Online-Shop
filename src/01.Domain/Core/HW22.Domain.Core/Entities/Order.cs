using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Entities
{
    public class Order : BaseEntity
    {
        public List<OrderItem> OrderItems { get; set; }
        public ApplicationUser User { get; set; }
        public int UserId { get; set; }

        public decimal TotalPrice { get; set; }
    }
}

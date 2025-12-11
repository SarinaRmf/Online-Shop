using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Dtos.Order
{
    public class GetOrderDto
    {
        public string CustomerFullName { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

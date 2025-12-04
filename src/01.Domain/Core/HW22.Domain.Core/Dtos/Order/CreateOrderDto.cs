using HW22.Domain.Core.Dtos.OrderItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Dtos.Order
{
    public class CreateOrderDto
    {
        public int UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public List<CreateOrderItemDto> OrederItems { get; set; }
    }
}

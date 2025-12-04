using HW22.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Dtos.Product
{
    public class GetProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public int Count { get; set; } //موجودی
    }
}

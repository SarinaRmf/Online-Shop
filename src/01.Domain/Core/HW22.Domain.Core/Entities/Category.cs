using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HW22.Domain.Core.Entities
{
    public class Category : BaseEntity
    {
        
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
}

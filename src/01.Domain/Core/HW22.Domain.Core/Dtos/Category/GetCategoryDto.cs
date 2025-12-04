using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Dtos.Category
{
    public class GetCategoryDto
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string ImagePath { get; set; }
    }
}

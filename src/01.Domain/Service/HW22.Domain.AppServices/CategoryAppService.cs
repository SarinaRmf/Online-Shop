using HW22.Domain.Core.Contracts.Category;
using HW22.Domain.Core.Dtos.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.AppServices
{
    public class CategoryAppService(ICategoryService categoryService) : ICategoryAppService
    {
        public Task<List<GetCategoryDto>> GetAll(CancellationToken cancellationToken)
        {
            return categoryService.GetAll(cancellationToken);
        }

        public Task<GetCategoryDto?> GetById(int id, CancellationToken cancellationToken)
        {
            return categoryService.GetById(id, cancellationToken);
        }
    }
}

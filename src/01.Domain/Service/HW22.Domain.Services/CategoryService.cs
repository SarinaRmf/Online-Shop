using HW22.Domain.Core.Contracts.Category;
using HW22.Domain.Core.Dtos.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Services
{
    public class CategoryService(ICategoryRepository _repo) : ICategoryService
    {
        public Task<List<GetCategoryDto>> GetAll(CancellationToken cancellationToken)
        {
            return _repo.GetAll(cancellationToken);
        }

        public Task<GetCategoryDto?> GetById(int id, CancellationToken cancellationToken)
        {
            return _repo.GetById(id, cancellationToken);
        }
    }
}

using HW22.Domain.Core.Dtos.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.Category
{
    public interface ICategoryRepository
    {
        Task<List<GetCategoryDto>> GetAll(CancellationToken cancellationToken);
        Task<GetCategoryDto?> GetById(int id, CancellationToken cancellationToken);
    }
}

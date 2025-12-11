using HW22.Domain.Core.Dtos._common;
using HW22.Domain.Core.Dtos.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.AppService
{
    public interface ICategoryAppService
    {
        Task<List<GetCategoryDto>> GetAll(CancellationToken cancellationToken);
        Task<GetCategoryDto?> GetById(int id, CancellationToken cancellationToken);
        Task<ResultDto<bool>> Create(CreateCategoryDto createCategoryDto);
        Task<ResultDto<bool>> Delete(int categoryId, CancellationToken cancellationToken);
        Task<ResultDto<bool>> Update(GetCategoryDto updateCategoryDto, CancellationToken cancellationToken);
    }
}

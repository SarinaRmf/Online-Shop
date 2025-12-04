using HW22.Domain.Core.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.Product
{
    public interface IProductAppService
    {
        Task<GetProductDto?> Get(int Id, CancellationToken cancellationToken);
        Task<List<GetProductDto>> GetAll(CancellationToken cancellationToken);
        Task<List<GetProductDto>> GetCategoryProducts(int categoryId, CancellationToken cancellationToken);
        Task<int> GetProductCount(int productId, CancellationToken cancellationToken);

    }
}

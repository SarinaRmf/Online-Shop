using HW22.Domain.Core.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.Servcie
{
    public interface IProductService
    {
        Task<GetProductDto?> Get(int Id, CancellationToken cancellationToken);
        Task<List<GetProductDto>> GetAll(CancellationToken cancellationToken);
        Task<List<GetProductDto>> GetCategoryProducts(int categoryId, CancellationToken cancellationToken);
        Task<int> GetProductCount(int productId, CancellationToken cancellationToken);
        Task<bool> UpdateCount(int productId, int count, CancellationToken cancellationToken);
        Task<bool> Create(CreateProductDto createProductDto);
        Task<bool> Delete(int productId, CancellationToken cancellationToken);
        Task<UpdateProductDto?> GetUpdatedProduct(int productId, CancellationToken cancellationToken);

        Task<bool> Update(UpdateProductDto updateProductDto, CancellationToken cancellationToken);
    }
}

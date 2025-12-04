using HW22.Domain.Core.Contracts.Product;
using HW22.Domain.Core.Dtos.Product;

namespace HW22.Domain.Services
{
    public class ProductService(IProductRepository _repo) : IProductService
    {
        public async Task<GetProductDto?> Get(int Id,CancellationToken cancellationToken)
        {
            return await _repo.GetDetails(Id, cancellationToken);
        }

        public async Task<List<GetProductDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _repo.GetAll(cancellationToken);
        }

        public async Task<List<GetProductDto>> GetCategoryProducts(int categoryId, CancellationToken cancellationToken)
        {
            return await _repo.GetCategoryProducts(categoryId, cancellationToken);
        }

        public async Task<int> GetProductCount(int productId, CancellationToken cancellationToken)
        {
            return await _repo.GetProductCount(productId, cancellationToken);
        }

        public async Task<bool> UpdateCount(int productId, int count, CancellationToken cancellationToken)
        {
            return await _repo.UpdateCount(productId, count, cancellationToken);
        }

    }
}

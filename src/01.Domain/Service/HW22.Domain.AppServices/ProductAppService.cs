using HW22.Domain.Core.Contracts.Product;
using HW22.Domain.Core.Dtos.Product;
using System.Threading;

namespace HW22.Domain.AppServices
{
    public class ProductAppService(IProductService productService) : IProductAppService
    {
        public async Task<GetProductDto> Get(int id, CancellationToken cancellationToken)
        {
            return await productService.Get(id,cancellationToken);
        }

        public async Task<List<GetProductDto>> GetAll(CancellationToken cancellationToken)
        {
            return await productService.GetAll(cancellationToken);
        }

        public async Task<List<GetProductDto>> GetCategoryProducts(int categoryId, CancellationToken cancellationToken)
        {
            return await productService.GetCategoryProducts(categoryId,cancellationToken);
        }

        public async Task<int> GetProductCount(int productId, CancellationToken cancellationToken)
        {
            return await productService.GetProductCount(productId,cancellationToken);
        }
    }
}

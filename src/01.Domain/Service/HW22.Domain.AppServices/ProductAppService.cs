using HW22.Domain.Core.Contracts.AppService;
using HW22.Domain.Core.Contracts.Servcie;
using HW22.Domain.Core.Dtos._common;
using HW22.Domain.Core.Dtos.Product;
using System.Threading;

namespace HW22.Domain.AppServices
{
    public class ProductAppService(IProductService productService) : IProductAppService
    {
        public async Task<ResultDto<bool>> Create(CreateProductDto createProductDto)
        {
            var result = await productService.Create(createProductDto);
            if (result)
            {
                return ResultDto<bool>.Success("Product created successfully", true);
            }
            return ResultDto<bool>.Failure("Failed to create product", false);
        }

        public async Task<ResultDto<bool>> Delete(int productId, CancellationToken cancellationToken)
        {
            var result = await productService.Delete(productId, cancellationToken);
            if (result)
            {
                return ResultDto<bool>.Success("Product deleted successfully", true);
            }
            return ResultDto<bool>.Failure("Failed to delete product", false);
        }

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

        public async Task<UpdateProductDto?> GetUpdatedProduct(int productId, CancellationToken cancellationToken)
        {
            return await productService.GetUpdatedProduct(productId, cancellationToken);
        }

        public async Task<ResultDto<bool>> Update(UpdateProductDto updateProductDto, CancellationToken cancellationToken)
        {
            var result = await  productService.Update(updateProductDto, cancellationToken);
            if (result)
            {
                return ResultDto<bool>.Success("Product updated successfully", true);
            }
            return ResultDto<bool>.Failure("Failed to update product", false);
        }

    }
}

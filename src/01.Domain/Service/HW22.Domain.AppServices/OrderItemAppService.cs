using HW22.Domain.Core.Contracts.OrderItem;
using HW22.Domain.Core.Contracts.Product;
using HW22.Domain.Core.Dtos._common;
using HW22.Domain.Core.Dtos.OrderItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.AppServices
{
    public class OrderItemAppService(IOrderItemService orderItemService,IProductService productService) : IOrderItemAppService
    {
        public async Task<ResultDto<bool>> Add(List<CreateOrderItemDto> orderItems, CancellationToken cancellationToken)
        {
            foreach (var item in orderItems)
            {
                if(item.Count > await productService.GetProductCount(item.ProductId, cancellationToken))
                {
                    return ResultDto<bool>.Failure("Not enough product in stock.");
                }

            }

            var result = await orderItemService.AddItems(orderItems, cancellationToken);
            if (result)
            {
                return ResultDto<bool>.Success("Orders Successfully Submited!");
            }
            return ResultDto<bool>.Failure("Failed in Adding Orders!");

        }
    }
}

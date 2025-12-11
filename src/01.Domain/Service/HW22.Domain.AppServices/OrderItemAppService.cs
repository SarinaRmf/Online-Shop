using HW22.Domain.Core.Contracts.AppService;
using HW22.Domain.Core.Contracts.Servcie;
using HW22.Domain.Core.Dtos._common;
using HW22.Domain.Core.Dtos.OrderItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.AppServices
{
    public class OrderItemAppService(IOrderItemService orderItemService, IProductService productService) : IOrderItemAppService
    {
        public async Task<List<GetOrderItemDto>> GetAll(int orderId, CancellationToken cancellationToken)
        {
            return await orderItemService.GetAll(orderId, cancellationToken);
        }
    }
}

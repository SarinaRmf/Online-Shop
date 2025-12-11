using HW22.Domain.Core.Dtos.OrderItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.Servcie
{
    public interface IOrderItemService
    {
        Task<bool> AddItems(List<CreateOrderItemDto> OrderItems, CancellationToken cancellationToken);
        Task<List<GetOrderItemDto>> GetAll(int orderId, CancellationToken cancellationToken);
    }
}

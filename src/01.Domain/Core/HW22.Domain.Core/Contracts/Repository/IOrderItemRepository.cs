using HW22.Domain.Core.Dtos.OrderItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.Repository
{
    public interface IOrderItemRepository
    {
        Task<bool> Add(List<CreateOrderItemDto> OrderItems, CancellationToken cancellationToken);
        Task<List<GetOrderItemDto>> GetAll(int orderId, CancellationToken cancellationToken);
    }
}

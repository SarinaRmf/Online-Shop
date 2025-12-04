using HW22.Domain.Core.Dtos.OrderItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.OrderItem
{
    public interface IOrderItemRepository
    {
        Task<bool> Add(List<CreateOrderItemDto> OrderItems, CancellationToken cancellationToken);
    }
}

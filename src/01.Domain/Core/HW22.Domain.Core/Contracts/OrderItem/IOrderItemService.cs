using HW22.Domain.Core.Dtos.OrderItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.OrderItem
{
    public interface IOrderItemService
    {
        Task<bool> AddItems(List<CreateOrderItemDto> OrderItems, CancellationToken cancellationToken);
    }
}

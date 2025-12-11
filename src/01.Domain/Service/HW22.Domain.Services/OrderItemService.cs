using HW22.Domain.Core.Contracts.Repository;
using HW22.Domain.Core.Contracts.Servcie;
using HW22.Domain.Core.Dtos.OrderItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Services
{
    public class OrderItemService(IOrderItemRepository _repo) : IOrderItemService
    {
        public async Task<bool> AddItems(List<CreateOrderItemDto> OrderItems, CancellationToken cancellationToken)
        {
            return await _repo.Add(OrderItems, cancellationToken);
        }

        public async Task<List<GetOrderItemDto>> GetAll(int orderId, CancellationToken cancellationToken)
        {
            return await _repo.GetAll(orderId, cancellationToken);
        }
    }
}

using HW22.Domain.Core.Contracts.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Services
{
    public class OrderService(IOrderRepository _repo): IOrderService
    {
        public async Task<int> Create(int userId, decimal totalPrice,CancellationToken cancellationToken)
        {
            return await _repo.Create(userId, totalPrice, cancellationToken);
        }
    }
}

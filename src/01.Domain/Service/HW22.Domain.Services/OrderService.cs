using HW22.Domain.Core.Contracts.Repository;
using HW22.Domain.Core.Contracts.Servcie;
using HW22.Domain.Core.Dtos.Order;
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

        public async Task<List<GetOrderDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _repo.GetAll(cancellationToken);
        }
    }
}

using HW22.Domain.Core.Dtos.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.Repository
{
    public interface IOrderRepository
    {
        Task<int> Create(int userId, decimal totalPrice, CancellationToken cancellationToken);
        Task<List<GetOrderDto>> GetAll(CancellationToken cancellationToken);
    }
}

using HW22.Domain.Core.Dtos.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.Servcie
{
    public interface IOrderService
    {
        Task<int> Create(int userId, decimal totalPrice, CancellationToken cancellationToken);
        Task<List<GetOrderDto>> GetAll(CancellationToken cancellationToken);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.Order
{
    public interface IOrderRepository
    {
        Task<int> Create(int userId, decimal totalPrice, CancellationToken cancellationToken);
    }
}

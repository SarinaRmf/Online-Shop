using HW22.Domain.Core.Contracts.Order;
using HW22.Domain.Core.Contracts.OrderItem;
using HW22.Domain.Core.Entities;
using HW22.Infra.Db.SqlServer.Ef;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Infra.Data.Repos.Ef
{
    public class OrderRepository(AppDbContext _context) : IOrderRepository
    {
        public async Task<int> Create(int userId, decimal totalPrice , CancellationToken cancellationToken)
        {
            var entity = new Order
            {
                UserId = userId,
                TotalPrice = totalPrice,
            };
            await _context.Orders.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return  entity.Id;
        }
    }
}

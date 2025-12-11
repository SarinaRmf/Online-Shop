using HW22.Domain.Core.Contracts.Repository;
using HW22.Domain.Core.Dtos.Order;
using HW22.Domain.Core.Entities;
using HW22.Infra.Db.SqlServer.Ef;
using Microsoft.EntityFrameworkCore;

namespace HW22.Infra.Data.Repos.Ef
{
    public class OrderRepository(AppDbContext _context) : IOrderRepository
    {
        public async Task<int> Create(int userId, decimal totalPrice, CancellationToken cancellationToken)
        {
            var entity = new Order
            {
                UserId = userId,
                TotalPrice = totalPrice,
            };
            await _context.Orders.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }

        public async Task<List<GetOrderDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _context.Orders.Select(o => new GetOrderDto
            {
                TotalPrice = o.TotalPrice,
                OrderId = o.Id,
                CustomerFullName = $"{o.User.FirstName} {o.User.LastName}",
                CreatedAt = o.CreatedAt
                
            }).ToListAsync(cancellationToken);
        }
    }
}

using HW22.Domain.Core.Contracts.OrderItem;
using HW22.Domain.Core.Dtos.OrderItem;
using HW22.Domain.Core.Entities;
using HW22.Infra.Db.SqlServer.Ef;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Infra.Data.Repos.Ef
{
    public class OrderItemRepository(AppDbContext context) : IOrderItemRepository
    {
        public async Task<bool> Add(List<CreateOrderItemDto> OrderItems,CancellationToken cancellationToken)
        {
            var entities = OrderItems.Select(o => new OrderItem
            {
                ProductId = o.ProductId,
                OrderId = o.OrderId.Value, /**/
                Count = o.Count,
                UnitPrice = o.UnitPrice
                
            }).ToList();

            await context.OrderItems.AddRangeAsync(entities, cancellationToken);
            return await context.SaveChangesAsync(cancellationToken) > 0;
        }
    }
}

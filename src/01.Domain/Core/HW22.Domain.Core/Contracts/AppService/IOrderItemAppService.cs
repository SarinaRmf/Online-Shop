using HW22.Domain.Core.Dtos.OrderItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.AppService
{
    public interface IOrderItemAppService
    {
        Task<List<GetOrderItemDto>> GetAll(int orderId, CancellationToken cancellationToken);
    }
}

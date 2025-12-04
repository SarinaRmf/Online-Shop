using HW22.Domain.Core.Dtos._common;
using HW22.Domain.Core.Dtos.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.Order
{
    public interface IOrderAppService
    {
        Task<ResultDto<bool>> MakeOrder(CreateOrderDto orderDto, CancellationToken cancellationToken);
    }
}

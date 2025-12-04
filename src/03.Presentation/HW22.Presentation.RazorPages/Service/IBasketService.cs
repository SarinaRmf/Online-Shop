using HW22.Domain.AppServices;
using HW22.Domain.Core.Dtos._common;
using HW22.Domain.Core.Dtos.OrderItem;
using HW22.Presentation.RazorPages.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Newtonsoft.Json;

namespace HW22.Presentation.RazorPages.Service
{
    public interface IBasketService
    {
        Task<ResultDto<bool>> AddToBasket(int productId, int count, CancellationToken cancellationToken);
        Basket GetBasket();
        void Write(Basket basket);
        Task<ResultDto<bool>> ClearItem(int productId, CancellationToken cancellationToken);
        Task RemoveItem(int productId, CancellationToken cancellationToken);
        Task<ResultDto<bool>> IncreaseItem(int productId, CancellationToken cancellationToken);
        void DeleteBasket();
        Task<List<GetOrderItemDto>> GetBasketItems(CancellationToken cancellationToken);
        int GetOrderCount();
        int GetOrderItemCount(int productId);
    }
}

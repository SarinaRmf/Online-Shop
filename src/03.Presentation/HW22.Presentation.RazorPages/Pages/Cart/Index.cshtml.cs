using HW22.Domain.Core.Contracts.Order;
using HW22.Domain.Core.Dtos.Order;
using HW22.Domain.Core.Dtos.OrderItem;
using HW22.Presentation.RazorPages.Extentions;
using HW22.Presentation.RazorPages.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading;

namespace HW22.Presentation.RazorPages.Pages.Cart
{
    public class IndexModel(IBasketService basketService, IOrderAppService orderAppService) : BasePage
    {
        public List<GetOrderItemDto> OrderItems {  get; set;  } = new();

        public string Message { get; set; }
        public async Task OnGet(CancellationToken cancellationToken)
        {
            OrderItems = await basketService.GetBasketItems(cancellationToken);
        }
        public async Task<IActionResult> OnGetAdd(int productId, CancellationToken cancellationToken)
        {
            var result = await basketService.IncreaseItem(productId, cancellationToken);
            Message = result.Message;

            return RedirectToPage("/Cart/Index");
        }
        public async Task<IActionResult> OnGetReduct(int productId, CancellationToken cancellationToken)
        {
            await basketService.RemoveItem(productId,cancellationToken);
            return RedirectToPage("/Cart/Index");
        }
        public async Task<IActionResult> OnGetClearItem(int productId, CancellationToken cancellationToken)
        {
            await basketService.ClearItem(productId, cancellationToken);
            return RedirectToPage("/Cart/Index");
        }
        public async Task<IActionResult> OnGetCheckOut(CancellationToken cancellationToken)
        {
            if (UserIsLoggedIn())
            {
                var basketItems = await basketService.GetBasketItems(cancellationToken);
                List<CreateOrderItemDto> orderItems = new List<CreateOrderItemDto>();
                foreach (var item in basketItems)
                {
                    var orderItem = new CreateOrderItemDto
                    {
                        ProductId = item.ProductId,
                        Count = item.Count,
                        UnitPrice = item.UnitPrice,
                    };
                    orderItems.Add(orderItem);
                }

                var Order = new CreateOrderDto()
                {
                    OrederItems = orderItems,
                    UserId = GetUserId(),
                    TotalPrice = basketItems.Sum(x => x.UnitPrice * x.Count)
                };
                var checkoutResult = await orderAppService.MakeOrder(Order, cancellationToken);
                basketService.DeleteBasket();

                TempData["AccountMessage"] = "Checked out Successfully";
                return RedirectToPage("/Home/Index");
            }
            else
            {
                return RedirectToPage("/Account/Login");
            }
        }

    }
}

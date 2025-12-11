using HW22.Domain.Core.Contracts.AppService;
using HW22.Domain.Core.Dtos.OrderItem;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Areas.Admin.Pages.Order
{
    public class OrderItmesModel(IOrderItemAppService orderItemAppService) : PageModel
    {
        public List<GetOrderItemDto> Items { get; set; }
        public async Task OnGet(int orderId, CancellationToken cancellationToken)
        {
            Items = await orderItemAppService.GetAll(orderId,cancellationToken);
        }
    }
}

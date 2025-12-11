using HW22.Domain.Core.Contracts.AppService;
using HW22.Domain.Core.Dtos.Order;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Areas.Admin.Pages.Order
{
    public class IndexModel(IOrderAppService orderAppService) : PageModel
    {
        public List<GetOrderDto> Orders { get; set; } = new List<GetOrderDto>();
        public async Task OnGet(CancellationToken cancellationToken)
        {
            Orders = await orderAppService.GetAll(cancellationToken);
        }
    }
}

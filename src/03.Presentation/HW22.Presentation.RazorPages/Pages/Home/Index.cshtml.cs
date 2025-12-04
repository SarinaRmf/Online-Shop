using HW22.Domain.Core.Contracts.Category;
using HW22.Domain.Core.Contracts.Product;
using HW22.Domain.Core.Dtos.Category;
using HW22.Domain.Core.Dtos.Product;
using HW22.Presentation.RazorPages.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Pages.Home
{
    public class HomeModel(IProductAppService productAppService, ICategoryAppService categoryAppService,IBasketService basketService) : PageModel
    {
        public List<GetProductDto> Products { get; set; }
        public List<GetCategoryDto> Categories { get; set; } = new();
        public string Message { get; set; }
        public async Task OnGet(CancellationToken cancellationToken)
        {
            Products = await productAppService.GetAll(cancellationToken);
            Categories = await categoryAppService.GetAll(cancellationToken);
        }

        public async Task<IActionResult> OnPostAddToBasket(int productId,CancellationToken cancellationToken)
        {
            var result = await basketService.IncreaseItem(productId, cancellationToken);
            Message = result.Message;

            return RedirectToPage("/Home/Index");
        }
    }
}

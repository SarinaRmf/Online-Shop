using HW22.Domain.Core.Contracts.Category;
using HW22.Domain.Core.Contracts.Product;
using HW22.Domain.Core.Dtos.Category;
using HW22.Domain.Core.Dtos.Product;
using HW22.Domain.Core.Entities;
using HW22.Presentation.RazorPages.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Pages.Product
{
    public class CategoryProductsModel(IProductAppService productAppService, ICategoryAppService categoryAppService, IBasketService basketService) : PageModel
    {
        public List<GetProductDto> ProductDtos { get; set; } = new List<GetProductDto>();
        public GetCategoryDto Category { get; set; } = new GetCategoryDto();
        public string Message { get; set; }
        public async Task OnGet(int categoryId, CancellationToken cancellationToken)
        {
            ProductDtos = await productAppService.GetCategoryProducts(categoryId, cancellationToken);
            Category = await categoryAppService.GetById(categoryId, cancellationToken);
        }
        public async Task<IActionResult> OnPostAddToBasket(int productId, int categoryId, CancellationToken cancellationToken)
        {
            var result = await basketService.IncreaseItem(productId, cancellationToken);
            Message = result.Message;
            return RedirectToPage("/Product/CategoryProducts",new { categoryId });
        }
    }
}

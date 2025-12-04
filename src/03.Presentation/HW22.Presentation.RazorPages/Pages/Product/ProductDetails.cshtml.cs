using HW22.Domain.Core.Contracts.Product;
using HW22.Domain.Core.Dtos.Product;
using HW22.Presentation.RazorPages.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Pages.Product
{
    public class ProductDetailsModel(IProductAppService productAppService,IBasketService basketService) : PageModel
    {
        public GetProductDto Product { get; set; }
        public string Message { get; set; }
        [BindProperty]
        public int OrderItemCount { get; set; }
        public async Task OnGet(int productId,CancellationToken cancellationToken)
        {
            Product = await productAppService.Get(productId, cancellationToken);
            OrderItemCount = basketService.GetOrderItemCount(productId);
        }

        public async Task<IActionResult> OnPostAddToCart(int productId, CancellationToken cancellationToken) {

            var result =await basketService.AddToBasket(productId, OrderItemCount, cancellationToken);
            Message = result.Message;
            return RedirectToPage("/Product/ProductDetails", new { productId });
        }
    }
}

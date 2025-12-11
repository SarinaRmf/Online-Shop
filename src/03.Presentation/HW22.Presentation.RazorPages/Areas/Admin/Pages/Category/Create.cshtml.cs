using HW22.Domain.Core.Contracts.AppService;
using HW22.Domain.Core.Dtos.Category;
using HW22.Presentation.RazorPages.Extentions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Areas.Admin.Pages.Category
{
    [Area(AreaConstants.Admin)]
    public class CreateModel(ICategoryAppService categoryAppService) : BasePage
    {
        [BindProperty]
        public CreateCategoryDto CategoryDto { get; set; }
        public void OnGet()
        {
            
            CategoryDto = new CreateCategoryDto();
            throw new Exception("Test error log");
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) {

                return Page();
            }
            var result = await categoryAppService.Create(CategoryDto);
            if (result.IsSuccess)
            {
                TempData["Message"] = result.Message;
                return RedirectToPage("/Category/Index");
            }
            else
            {
                TempData["ErrorMessage"] = result.Message;
                return RedirectToPage("/Category/Create");
            }
        }
    }
}

using HW22.Domain.Core.Contracts.AppService;
using HW22.Domain.Core.Dtos.User;
using HW22.Presentation.RazorPages.Extentions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Pages.Account
{
    public class EditModel(IUserAppService userAppService) : BasePage
    {
        [BindProperty]
        public UserProfileDto userProfileDto { get; set; }
        public async Task OnGet()
        {
            userProfileDto = await userAppService.GetProfile((int)GetUserId()!);
        }
        public async Task<IActionResult> OnPost() { 
            
            var result = await userAppService.UpdateProfile((int)GetUserId()!, userProfileDto);
            if(result.IsSuccess)
            {
                TempData["AccountMessage"] = result.Message;
                return RedirectToPage("/Account/Profile");
            }
            else
            {
                ModelState.AddModelError(string.Empty, result.Message);
                return Page();
            }
        }
    }
}

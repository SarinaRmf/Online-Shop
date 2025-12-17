using HW22.Domain.Core.Contracts.AppService;
using HW22.Domain.Core.Dtos.User;
using HW22.Presentation.RazorPages.Extentions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Pages.Account
{
    public class ChangePasswordModel(IUserAppService userAppService) : BasePage
    {
        [BindProperty]
        public UpdateUserPasswordDto passwordDto { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var result = await userAppService.ChangePassword((int)GetUserId() ,passwordDto);
            if (result.IsSuccess)
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

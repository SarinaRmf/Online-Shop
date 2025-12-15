using HW22.Domain.Core.Contracts.AppService;
using HW22.Domain.Core.Dtos.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Pages.Account
{
    public class RegisterModel(IUserAppService userAppService) : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        public RegisterUserDto registerUserDto { get; set; }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostRegister(CancellationToken cancellationToken)
        {
            var registerResult = await userAppService.Register(registerUserDto, cancellationToken);
            if (registerResult.IsSuccess)
            {
                TempData["AccountMessage"] = registerResult.Message;
                return RedirectToPage("/Account/Login");
            }
            else
            {
                Message = registerResult.Message;
                return Page();
            }
        }
    }
}

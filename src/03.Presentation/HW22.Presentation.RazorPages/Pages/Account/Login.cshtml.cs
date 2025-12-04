using HW22.Domain.Core.Contracts.User;
using HW22.Presentation.RazorPages.Extentions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Pages.Account
{
    public class LoginModel(IUserAppService userAppService, ICookieService cookieService) : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostLogin(CancellationToken cancellationToken)
        {
            var loginResult = await userAppService.Login(Username, Password, cancellationToken);
            if (loginResult.IsSuccess)
            {
                cookieService.Set("Id", loginResult.Data.UserId.ToString());
                cookieService.Set("Username", loginResult.Data.UserName);

                TempData["AccountMessage"] = loginResult.Message;
                return RedirectToPage("/Home/Index");
            }
            else
            {

                Message = loginResult.Message;
                return Page();
            }

        }
        public async Task<IActionResult> OnGetLogout()
        {
            cookieService.Delete("Id");
            TempData["AccountMessage"] = "Log out Successfully";
            return RedirectToPage("/Home/Index");    
        }
    }
}

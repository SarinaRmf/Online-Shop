using HW22.Domain.Core.Contracts.AppService;
using HW22.Domain.Core.Dtos.User;
using HW22.Presentation.RazorPages.Extentions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Pages.Account
{
    public class ProfileModel(IUserAppService userAppService) : BasePage
    {
        public UserProfileDto UserProfile { get; set; }
        public async Task OnGet()
        {
            UserProfile = await userAppService.GetProfile((int)GetUserId()!);
        }
    }
}

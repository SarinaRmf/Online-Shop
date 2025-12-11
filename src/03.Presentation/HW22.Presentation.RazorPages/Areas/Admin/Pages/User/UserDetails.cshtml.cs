using HW22.Domain.Core.Contracts.AppService;
using HW22.Domain.Core.Dtos.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Areas.Admin.Pages.User
{
    public class UserDetailsModel(IUserAppService userAppService) : PageModel
    {
        public GetUserDto UserDetails { get; set; } = new GetUserDto();
        public async Task OnGet(int userId, CancellationToken cancellationToken)
        {
            UserDetails = await userAppService.GetUserDetails(userId,cancellationToken);
        }
    }
}

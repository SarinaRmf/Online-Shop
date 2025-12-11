using HW22.Domain.Core.Contracts.AppService;
using HW22.Domain.Core.Dtos.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Areas.Admin.Pages.User
{
    public class IndexModel(IUserAppService userAppService) : PageModel
    {
        public List<GetUserDto> Users { get; set; } = new List<GetUserDto>();

        public async Task OnGet(CancellationToken cancellationToken)
        {
            Users = await userAppService.GetUsers(cancellationToken);
        }
    }
}

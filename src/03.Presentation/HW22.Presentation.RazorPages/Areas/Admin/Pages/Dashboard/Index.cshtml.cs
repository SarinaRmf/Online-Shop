using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW22.Presentation.RazorPages.Areas.Admin.Pages.Dashboard
{
    [Authorize(Roles ="Admin")]
    [Area(AreaConstants.Admin)]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

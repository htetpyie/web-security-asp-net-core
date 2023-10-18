using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjectName.Pages
{

    [Authorize(Policy = "AdminOlny")]
    public class SettingsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

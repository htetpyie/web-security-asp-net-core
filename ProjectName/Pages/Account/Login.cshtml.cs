using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace ProjectName.Pages.Account
{
    public class LoginModel : PageModel
    {
        public Credential Credential { get; set; }
        public void OnGet()
        {
        }
    }
    public class Credential
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

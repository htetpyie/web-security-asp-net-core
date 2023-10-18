using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ProjectName.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            //Verity the Credential
            if (Credential.UserName == "admin" && Credential.Password == "admin")
            {
                //Creating a security context
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,"admin"),
                    new Claim(ClaimTypes.Email, "admin@gmail.com"),
                    new Claim("Department","HR"),
                    new Claim("Admin","true"),
                    new Claim("Manager","true"),
                    new Claim("EmploymentDate","2023-07-11")
                };

                var identity = new ClaimsIdentity(claims, "CookieAuthTest");

                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                var authProp = new AuthenticationProperties
                {
                    IsPersistent = Credential.IsRemember,
                };

                await HttpContext.SignInAsync("CookieAuthTest", claimsPrincipal, authProp);

                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}

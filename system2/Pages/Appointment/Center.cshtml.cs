using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace system2.Pages.Appointment
{
    public class CenterModel : PageModel
    {
        [BindProperty]
        public string Token { get; set; }

        public IActionResult OnGet(string token)
        {
            Token = token;

            return Page();
        }
    }
}

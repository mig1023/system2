using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using system2.Services;

namespace system2.Pages.Appointment
{
    public class InitializationModel : PageModel
    {
        private readonly IToken _token;

        public InitializationModel()
        {
            _token = new Token();
        }

        public IActionResult OnGet()
        {
            string token = _token.Generate();
            return RedirectToPage("Center", new { token = token, page = 1 });
        }
    }
}

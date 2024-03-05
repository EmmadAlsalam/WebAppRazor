using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPages.Models;
namespace WebAppRazorPages.Pages;

public class SignInModel : PageModel
{
    public string PageTitle { get; set; } = "Sign In";

    [BindProperty]
    public SignInFormModel From { get; set; } = new SignInFormModel();
    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        TempData["ReloadPage"] = true;

        // Redirect till /singup
        return RedirectToPage("/singup");
    }
}

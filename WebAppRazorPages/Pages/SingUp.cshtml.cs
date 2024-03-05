using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPages.Models;
namespace WebAppRazorPages.Pages;
public class SingUpModel : PageModel
{
    public string PageTitle { get; set; } = "Sign up";

    [BindProperty]
    public SignUpFormModel From { get; set; } = new SignUpFormModel();
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

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_RazorPages.Pages
{
    public class IndexModel : PageModel
    {

        public List<string> Brands { get; set; } =
        [
            "images/brand_1.svg",
            "images/brand_2.svg",
            "images/brand_3.svg",
            "images/brand_4.svg",

        ];

        public void OnGet()
        {
        }
    }
}

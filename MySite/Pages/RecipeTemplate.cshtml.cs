using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MySite.Pages
{
    public class RecipeTemplateModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = Request.Query["recipe"];
        }
    }
}

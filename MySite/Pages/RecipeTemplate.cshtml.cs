using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Models;
namespace MySite.Pages
{
    public class RecipeTemplateModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = Request.Query["recipe"];
            ViewData["Recipe"] = new Recipe();
        }
    }
}

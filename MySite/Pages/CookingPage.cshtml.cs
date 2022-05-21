using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using MySite.Models;
using Microsoft.EntityFrameworkCore;
namespace MySite.Pages
{
    public class CookingPageModel : PageModel
    {
        public async void OnGet(CookingDbContext db)
        {
            ViewData["recipes"] = await db.Recipes
                .Select(r => new BriefRecipe(r))
                .ToArrayAsync();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Models;
using MySite.Data;
using Microsoft.EntityFrameworkCore;
namespace MySite.Pages
{
    public class RecipeTemplateModel : PageModel
    {
        public async void OnGet(CookingDbContext db)
        {
            ViewData["Title"] = Request.Query["recipe"];
            ViewData["Recipe"] = await db.Recipes
                .FindAsync(Request.Query["recipe"]);
            ViewData["Ingredients"] = await db.RecipeIngredient
                .Where(ri => ri.RecipeId == Request.Query["recipe"])
                .Include(ri => ri.Ingredient)
                .ToArrayAsync();
        }
    }
}

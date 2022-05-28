using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using MySite.Models;
using Microsoft.EntityFrameworkCore;
namespace MySite.Pages
{
    public class RecipeTemplateModel : PageModel
    {
        public async void OnGet([FromServices] CookingDbContext db)
        {
            db.Database.OpenConnection();
            var recipe = await db.Recipes
                .FindAsync(int.Parse(Request.Query["recipe"].ToString()));
            if (recipe is null)
            {
                db.Database.CloseConnection();
                return;
            }

            ViewData["Title"] = recipe.Name;
            ViewData["Recipe"] = recipe;
            ViewData["Ingredients"] = await db.RecipeIngredient
                .Where(ri => ri.RecipeId == recipe.RecipeId)
                .Include(ri => ri.Ingredient)
                .ToArrayAsync();
            db.Database.CloseConnection();
        }
    }
}
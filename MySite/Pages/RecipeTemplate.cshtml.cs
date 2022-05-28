using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using MySite.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace MySite.Pages
{
    public class RecipeTemplateModel : PageModel
    {
        CancellationTokenSource tokenSource = new CancellationTokenSource();
        CancellationToken token;
        public async void OnGet([FromServices] CookingDbContext db)
        {
            token = tokenSource.Token;
            var recipe = await db.Recipes
                .FindAsync(int.Parse(Request.Query["recipe"].ToString()));
            if (recipe is null)
            {
                tokenSource.Cancel();
                return;
            }

            ViewData["Title"] = recipe.Name;
            ViewData["Recipe"] = recipe;
            ViewData["Ingredients"] = await db.RecipeIngredient
                .Where(ri => ri.RecipeId == recipe.RecipeId)
                .Include(ri => ri.Ingredient)
                .ToArrayAsync();
            tokenSource.Cancel();
        }

        public async Task WaitData()
        {
            try
            {
                while (true)
                {
                    token.ThrowIfCancellationRequested();
                }
            }
            catch (Exception)
            {
                Debug.Print("Data Loaded");
            }
        }
    }
}
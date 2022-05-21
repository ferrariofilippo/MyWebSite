using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Models;
using MySite.Data;
using Microsoft.EntityFrameworkCore;
namespace MySite.Pages
{
    public class TravelTemplateModel : PageModel
    {
        public async void OnGet(TravelDbContext db)
        {
            ViewData["Title"] = Request.Query["country"];
            ViewData["Travel"] = await db.Travels
                .FindAsync(Request.Query["country"]);
            ViewData["Places"] = await db.SuggestedPlaces
                .Where(sp => sp.Country == Request.Query["country"])
                .ToArrayAsync();
        }
    }
}
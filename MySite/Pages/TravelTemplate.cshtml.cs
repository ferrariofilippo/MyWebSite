using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using Microsoft.EntityFrameworkCore;
namespace MySite.Pages
{
    public class TravelTemplateModel : PageModel
    {
        public async void OnGet([FromServices]TravelDbContext db)
        {
            db.Database.OpenConnection();
            ViewData["Title"] = Request.Query["country"];

            var country = await db.Travels
                .Where(t => t.Country == Request.Query["country"])
                .FirstOrDefaultAsync();
            if (country is null)
            {
                db.Database.CloseConnection();
                return;
            }

            ViewData["Travel"] = country;
            ViewData["Places"] = await db.SuggestedPlaces
                .Where(sp => sp.TravelId == country.TravelId)
                .ToArrayAsync();
            db.Database.CloseConnection();
        }
    }
}
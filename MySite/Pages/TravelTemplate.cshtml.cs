using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace MySite.Pages
{
    public class TravelTemplateModel : PageModel
    {
        CancellationTokenSource tokenSource = new CancellationTokenSource();
        CancellationToken token;
        public async void OnGet([FromServices]TravelDbContext db)
        {
            token = tokenSource.Token;
            ViewData["Title"] = Request.Query["country"];

            var country = await db.Travels
                .Where(t => t.Country == Request.Query["country"].ToString())
                .FirstOrDefaultAsync();
            if (country is null)
            {
                tokenSource.Cancel();   
                return;
            }

            ViewData["Travel"] = country;
            ViewData["Places"] = await db.SuggestedPlaces
                .Where(sp => sp.TravelId == country.TravelId)
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
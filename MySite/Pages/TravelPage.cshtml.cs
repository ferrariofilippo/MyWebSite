using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using MySite.Models;
using Microsoft.EntityFrameworkCore;
namespace MySite.Pages
{
    public class TravelPageModel : PageModel
    {
        public async void OnGet(TravelDbContext db)
        {
            ViewData["travels"] = await db.Travels
                .Select(t => new BriefTravel(t))
                .ToArrayAsync();
        }
    }
}
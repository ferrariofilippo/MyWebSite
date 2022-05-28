using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using MySite.Models;
using Microsoft.EntityFrameworkCore;
namespace MySite.Pages
{
    public class MindPageModel : PageModel
    {
        public async void OnGet([FromServices] MindDbContext db)
        {
            db.Database.OpenConnection();
            ViewData["pages"] = await db.Pages
                .Select(p => new BriefMind(p))
                .ToArrayAsync();
            db.Database.CloseConnection();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using MySite.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace MySite.Pages
{
    public class CodingPageModel : PageModel
    {
        public async void OnGet([FromServices] CodingDbContext db)
        {
            db.Database.OpenConnection();
            ViewData["projects"] = await db.Projects
                .Select(p => new BriefProject(p))
                .ToArrayAsync();
            db.Database.CloseConnection();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using MySite.Models;
using Microsoft.EntityFrameworkCore;
namespace MySite.Pages
{
    public class CodingPageModel : PageModel
    {
        public async void OnGet(CodingDbContext db)
        {
            ViewData["projects"] = await db.Projects
                .Select(p => new BriefProject(p))
                .ToArrayAsync();
        }
    }
}

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
        CancellationTokenSource tokenSource = new CancellationTokenSource();
        CancellationToken token;
        public async void OnGet([FromServices] CodingDbContext db)
        {
            token = tokenSource.Token;
            ViewData["projects"] = await db.Projects
                .Select(p => new BriefProject(p))
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
            catch(Exception)
            {
                Debug.Print("Data Loaded");
            }
        }
    }
}

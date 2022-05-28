using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using MySite.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace MySite.Pages
{
    public class MindPageModel : PageModel
    {
        CancellationTokenSource tokenSource = new CancellationTokenSource();
        CancellationToken token;
        public async void OnGet([FromServices] MindDbContext db)
        {
            token = tokenSource.Token;
            ViewData["pages"] = await db.Pages
                .Select(p => new BriefMind(p))
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
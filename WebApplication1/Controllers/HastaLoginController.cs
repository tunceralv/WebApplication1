using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Claims;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HastaLoginController : Controller
    {
        HastaneSistemiContext db = new HastaneSistemiContext();
        public async Task<IActionResult> Login(Hasta hasta)
        {
            var bilgiler = db.Hasta.FirstOrDefault(x => x.HastaEmail == hasta.HastaEmail && x.HastaTc == hasta.HastaTc);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,hasta.HastaEmail)
                };
                var identity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View();
            }
            
        }

    public IActionResult Register(Hasta hasta)
        {
            return View();

        }
    }
}

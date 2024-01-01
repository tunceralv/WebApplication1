using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        HastaneSistemiContext db = new HastaneSistemiContext();
        public async Task<IActionResult> Login(Hasta hasta,AdminTable ad)
        {
            var bilgiler = db.Hasta.FirstOrDefault(x => x.HastaEmail == hasta.HastaEmail && x.HastaTc == hasta.HastaTc);
            var bilgiler1 = db.AdminTables.FirstOrDefault(x => x.AdminEmail == ad.AdminEmail && x.Adminsifre == ad.Adminsifre);
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
            else if (bilgiler1 != null)
            {
                {
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,ad.AdminEmail)
                };
                    var identity = new ClaimsIdentity(claims, "Admin");
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Admin", "Admin");

                }
            }
            else
            {
                return View();
            }
            
        }
      /*  public async Task<IActionResult> AdminGiris(AdminTable ad)
        {
            var bilgiler = db.AdminTables.FirstOrDefault(x => x.AdminEmail == ad.AdminEmail && x.Adminsifre == ad.Adminsifre);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,ad.AdminEmail)
                };
                var identity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Admin", "Admin");

            }
            return View();
        } */
    public IActionResult Register()
        {
            return View();
        }
    }
}

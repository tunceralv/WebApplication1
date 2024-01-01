using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Claims;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AdminLoginController : Controller
    {
        HastaneSistemiContext db = new HastaneSistemiContext();
        public async Task<IActionResult> AdminGiris(AdminTable admin)
        {
            var bilgiler = db.AdminTables.FirstOrDefault(y => y.AdminEmail == admin.AdminEmail && y.Adminsifre == admin.Adminsifre);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
        {
                     new Claim(ClaimTypes.Name,admin.AdminEmail)
        };
                var identity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Admin", "Admin");
            }
            else
            {
                return View();
            }
        }

        public IActionResult AdminRegister(AdminTable admin)
        {

            db.AdminTables.Add(admin);
            db.SaveChanges();
            return View(admin);

        }
    }
}

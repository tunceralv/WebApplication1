using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BolumController : Controller
    {
        HastaneSistemiContext db = new HastaneSistemiContext();
        public IActionResult BolumEkle(BolumTable bolum)
        {
            db.BolumTables.Add(bolum);
            db.SaveChanges();
            return View(bolum);
        }
    }
}

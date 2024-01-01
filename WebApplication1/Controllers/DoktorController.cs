using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DoktorController : Controller
    {
        HastaneSistemiContext db = new HastaneSistemiContext();
        public IActionResult DoktorEkle(DoktorTable doktor)
        {
            db.DoktorTables.Add(doktor);
            db.SaveChanges();
            return View(doktor);
        }
    }
}

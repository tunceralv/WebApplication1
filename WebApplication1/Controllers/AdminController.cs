using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Web;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
    }
}

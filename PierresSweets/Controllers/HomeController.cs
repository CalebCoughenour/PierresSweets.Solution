using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PierresSweets.Models;

namespace PierresSweets.Controllers
{
    public class HomeController : Controller
    {

      private readonly PierresSweetsContext _db;
      public HomeController(PierresSweetsContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.Flavors = _db.Flavors.ToList();
        ViewBag.Treats = _db.Treats.ToList();
        return View();
      }

    }
}
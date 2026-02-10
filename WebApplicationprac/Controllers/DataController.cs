using Microsoft.AspNetCore.Mvc;
using WebApplicationprac.Models;

namespace WebApplicationprac.Controllers
{
    public class DataController : Controller
    {

        public Appdb _db;
        public DataController() {
            _db = new Appdb();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterModel obj)
        {

            //db

            //add(obj);
            _db.Register.Add(obj);
            _db.SaveChanges();
            return View();
        }

    }
}

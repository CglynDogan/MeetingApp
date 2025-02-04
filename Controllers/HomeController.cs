using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;
namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        //localhost
        //localhost/home
        //localhost/home/index
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            //int saat = 13;
            //var selamlama = saat > 12 ? "Iyi Gunler" : "Gunaydin";

            // ViewBag.Selamlama = saat > 12 ? "Iyi gunler" : "Gunaydin";
            // ViewBag.Username = "Caglayan";

            ViewData["Selamlama"] = saat > 12 ? "Iyi gunler" : "Gunaydin";
            ViewData["UserName"] = "Caglayan";

            var meetingInfo = new MeetingInfo
            {
                Id = 1,
                Location = "Istanbul , Abc kongre merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = 100
            };

            return View(meetingInfo);
        }
    }
}
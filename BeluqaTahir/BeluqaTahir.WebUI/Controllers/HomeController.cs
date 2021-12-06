using BeluqaTahir.Applications.ContactModules;
using BeluqaTahir.Applications.HappyClientss;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BeluqaTahir.WebUI.Controllers
{
    public class HomeController : Controller
    {

        readonly IMediator db;

        public HomeController(IMediator db)
        {
            this.db = db;

        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About(AboutPagedQuery query)
        {

            var respons = await db.Send(query);

            return View(respons);
        }

        [HttpGet]
        //+
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        //+
        public async Task<IActionResult> Contact(ContactCreateCommand query)
        {

            var respons = await db.Send(query);
            return Json(respons);
        }
    }
}

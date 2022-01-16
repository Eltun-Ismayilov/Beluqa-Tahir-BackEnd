using BeluqaTahir.Applications.BlogMolus;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BeluqaTahir.WebUI.Controllers
{

    public class BlogController : Controller
    {

        readonly IMediator db;

        public BlogController(IMediator db)
        {
            this.db = db;


        }
        [AllowAnonymous]
        public async Task<IActionResult> Index(BlogPagedQuery query)
        {

            var respons = await db.Send(query);

            return View(respons);

        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(BlogList query)
        {

            var respons = await db.Send(query);

            return View(respons);
        }



    }
}

using BeluqaTahir.Applications.BlogMolus;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BeluqaTahir.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogPostsController : Controller
    {
        private readonly IMediator mediator;

        public BlogPostsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

       
        public async Task<IActionResult> Index(BlogPagedQuery request)
        {
            var response = await mediator.Send(request);

            return View(response);
        }

        public async Task<IActionResult> Details(BlogSingleQuery query)
        {
            var respons = await mediator.Send(query);

            if (respons == null)
            {
                return NotFound();
            }

            return View(respons);
        }



    }
}

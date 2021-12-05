using BeluqaTahir.Applications.ShopMolus;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeluqaTahir.WebUI.Controllers
{
    public class ShopController : Controller
    {

        readonly IMediator db;

        public ShopController(IMediator db)
        {
            this.db = db;

        }
        public async Task<IActionResult> Index(ShopList query)
        {
            var respons = await db.Send(query);
            return View(respons);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}

using BeluqaTahir.Applications.ShopMolus;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous]
        public async Task<IActionResult> Index(ShopList query)
        {
            var respons = await db.Send(query);
            return View(respons);
        }

        public async Task<IActionResult> Details(ShopSingleQuery query )
        {
            var respons = await db.Send(query);

            return View(respons);
        }
    }
}

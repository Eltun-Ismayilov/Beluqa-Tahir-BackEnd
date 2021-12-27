using BeluqaTahir.Applications.ShopMolus;
using BeluqaTahir.Domain.Model.DataContexts;
using BeluqaTahir.Domain.Model.Entity;
using BeluqaTahir.Domain.Model.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeluqaTahir.WebUI.Controllers
{
    public class ShopController : Controller
    {

        readonly IMediator db;
        readonly BeluqaTahirDbContext bt;

        public ShopController(IMediator db, BeluqaTahirDbContext bt)
        {
            this.db = db;
            this.bt = bt;

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


        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null) return NotFound();

            var product = await bt.products.FindAsync(id);

            if (product == null) return NotFound();

            List<BasketViewModel> basketViewModels = new List<BasketViewModel>();
            if (Request.Cookies["basket"]!=null)
            {
                basketViewModels = JsonConvert.DeserializeObject<List<BasketViewModel>>(Request.Cookies["basket"]);
            }

            BasketViewModel isExitProduct = basketViewModels.FirstOrDefault(b => b.Id == id);
            if (isExitProduct==null)
            { 
                BasketViewModel basketVM = new BasketViewModel { Id = product.Id, Count = 1 };
                basketViewModels.Add(basketVM);
            }
            else
            {
                isExitProduct.Count += 1;
            }

           // ViewBag.basket = basketViewModels.Sum(p => p.Count);
            string basket = JsonConvert.SerializeObject(basketViewModels);
          
            Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(10) });

            return RedirectToAction(nameof(Index));
        


        }

        public async Task<IActionResult> Basket()
        {
            List<BasketViewModel> basketvms = JsonConvert.DeserializeObject<List<BasketViewModel>>(Request.Cookies["basket"]);
            List<BasketRazorVM> baskets = new List<BasketRazorVM>();

            foreach (var item in basketvms)
            {
                Product product = await bt.products.FindAsync(item.Id);
                BasketRazorVM basketRazorVM = new BasketRazorVM
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    ImagePati = product.ImagePati,
                   // Count = product.Count
                };
                baskets.Add(basketRazorVM);

            }

         //   TempData["xxx"]= basketRazorVM.count

            return View(baskets);
        }
    }
}

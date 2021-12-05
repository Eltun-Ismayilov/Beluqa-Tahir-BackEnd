﻿using BeluqaTahir.Applications.BlogMolus;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<IActionResult> Index(BlogPagedQuery query)
        {

            var respons = await db.Send(query);

            return View(respons);
        }

        public async Task<IActionResult> Details(BlogSingleQuery query)
        {

            var respons = await db.Send(query);

            return View(respons);
        }
    }
}

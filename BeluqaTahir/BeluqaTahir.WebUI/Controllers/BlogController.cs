using BeluqaTahir.Applications.BlogMolus;
using BeluqaTahir.Domain.Model.DataContexts;
using BeluqaTahir.Domain.Model.Entity;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BeluqaTahir.WebUI.Controllers
{

    public class BlogController : Controller
    {

        readonly IMediator db;
        readonly BeluqaTahirDbContext bt;

        public BlogController(IMediator db, BeluqaTahirDbContext bt)
        {
            this.db = db;
            this.bt = bt;


        }
        [AllowAnonymous]

        public async Task<IActionResult> Index(BlogPagedQuery query)
        {
            Request.Cookies.TryGetValue("basket", out string basketJson1);
            if (basketJson1?.Length > 0)
            {
                string[] arr = basketJson1.Split(',');
                ViewBag.ms = arr.Length / 2;
            }
            else
            {
                ViewBag.ms = 0;
            }
            var respons = await db.Send(query);

            return View(respons);

        }

        public async Task<IActionResult> Details(BlogList query)
        {
            Request.Cookies.TryGetValue("basket", out string basketJson1);
            if (basketJson1?.Length > 0)
            {
                string[] arr = basketJson1.Split(',');
                ViewBag.ms = arr.Length / 2;
            }
            else
            {
                ViewBag.ms = 0;
            }
            var respons = await db.Send(query);

            return View(respons);
        }


        [HttpPost]
        public async Task<IActionResult> PostComment(int? commentId, int postId, string comment)
        {
            if (string.IsNullOrWhiteSpace(comment))
            {
                return Json(new
                {
                    error = true,
                    message = "Serh bos buraxila bilmez!"
                });
            }

            if (postId < 1)
            {
                return Json(new
                {
                    error = true,
                    message = "Post movcud deyil!"
                });
            }


            var post = await bt.blogPosts.FirstOrDefaultAsync(c => c.Id == postId);


            if (post == null)
            {
                return Json(new
                {
                    error = true,
                    message = "Post movcud deyil!"
                });
            }

            var commentModel = new BlogPostComment
            {
                ParentId = commentId,
                BlogPostId = postId,
                Comment = comment,
                CreateByUserId= Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)
            };
            if (commentId.HasValue && await bt.BlogPostComments.AnyAsync(c => c.Id == commentId))
                commentModel.ParentId = commentId;

            await bt.BlogPostComments.AddAsync(commentModel);
            await bt.SaveChangesAsync();



            //return Json(new
            //{
            //    error = false,
            //    message = "Elave edildi!"
            //});
            commentModel = await bt.BlogPostComments
                .Include(c => c.CreateByUserId)
                .Include(c => c.Parent)
                .FirstOrDefaultAsync(c => c.Id == commentModel.Id);

            return PartialView("_Comment", commentModel);
        }

    }
}

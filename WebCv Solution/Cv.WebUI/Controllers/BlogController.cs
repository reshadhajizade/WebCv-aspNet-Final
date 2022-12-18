using WebCv.Domain.AppCode.Extensions;
using WebCv.Domain.Business.BlogPostModule;
using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using WebCv.Domain.Models.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace WebCv.WebUI.Controllers
{

    public class BlogController : Controller
    {
        private readonly IMediator mediator;
        private readonly WebCvDbContext db;

        public BlogController(IMediator mediator, WebCvDbContext db)
        {
            this.mediator = mediator;
            this.db = db;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(BlogPostGetAllQuery query)
        {
            var response = await mediator.Send(query);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_PostsBody", response);
            }
            return View(response);
        }



        [AllowAnonymous]
        [HttpGet]
        [Route("/blog/{slug}")]
        public async Task<IActionResult> Details(BlogPostGetSingleQuery query)
        {

            var blogPost = await mediator.Send(query);

            if (blogPost == null)
            {
                return NotFound();
            }


            return View(blogPost);
        }

        [HttpPost]
        public async Task<IActionResult> PostComment(BlogPostCommentCommand command)
        {

            try
            {
                var response = await mediator.Send(command);
                return PartialView("_Comments", response);
            }
            catch (System.Exception ex)
            {
                return Json(new
                {
                    error = true,
                    message = ex.Message
                });
            }

            

        }


    }
}

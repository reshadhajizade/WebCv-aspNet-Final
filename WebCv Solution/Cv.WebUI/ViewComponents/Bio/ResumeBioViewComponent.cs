﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebCv.Domain.Business.ResumeModule.Bio;
using WebCv.Domain.Models.DataContexts;
using System.Threading.Tasks;

namespace MyResume.WebUI.AppCode.ViewComponents.Bio
{
    public class ResumeBioViewComponent : ViewComponent
    {
        private readonly WebCvDbContext db;

        public ResumeBioViewComponent(WebCvDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await db.ResumeBios.FirstOrDefaultAsync();

            if (data == null)
            {
                return null;
            }

            return View(await Task.FromResult(data));
        }
    }
}

﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using WebCv.Domain.AppCode.Extensions;
using WebCv.Domain.AppCode.Infrastructure;
using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace WebCv.Domain.Business.BlogPostModule
{
    public class BlogPostPostCommand : IRequest<JsonResponse>
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

        public class BlogPostPostCommandHandler : IRequestHandler<BlogPostPostCommand, JsonResponse>
        {
            private readonly WebCvDbContext db;
            private readonly IHostEnvironment env;

            public BlogPostPostCommandHandler(WebCvDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(BlogPostPostCommand request, CancellationToken cancellationToken)
            {
                var entity = new BlogPost();
                
                entity.Title = request.Title;
                entity.Body = request.Body;
                

                if (request.Image == null)
                    goto end;

                string extension = Path.GetExtension(request.Image.FileName);

                request.ImagePath = $"blogpost-{Guid.NewGuid().ToString().ToLower()}{extension}";
                string fullPath = env.GetImagePhysicalPath(request.ImagePath);

                using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    request.Image.CopyTo(fs);
                }

                entity.ImagePath = request.ImagePath;

            end:
                entity.Slug = request.Title.ToSlug();

                await db.BlogPosts.AddAsync(entity, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return new JsonResponse
                {
                    Error = false,
                    Message = "Success"
                };
            }
        }
    }
}

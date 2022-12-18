using WebCv.Domain.Business.BlogPostModule;
using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebCv.Domain.Models.DataContexts;

namespace WebCv.Domain.Business.BrandModule
{
    public class BlogPostRemoveBackCommand : IRequest<BlogPost>
    {
        public int Id { get; set; }
        public class BlogPostRemoveBackCommandHandler : IRequestHandler<BlogPostRemoveBackCommand, BlogPost>
        {
            private readonly WebCvDbContext db;

            public BlogPostRemoveBackCommandHandler(WebCvDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPost> Handle(BlogPostRemoveBackCommand request, CancellationToken cancellationToken)
            {
                var data = db.BlogPosts.FirstOrDefault(m => m.Id == request.Id && m.DeletedDate != null);

                if (data == null)
                {
                    return null;
                }
                data.DeletedDate = null;
                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}


﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.BlogPostModule
{
    public class BlogPostGetSingleCommentQuery : IRequest<BlogPostComment>
    {
        public int Id { get; set; }
        public class BlogPostGetSingleCommentQueryHandler : IRequestHandler<BlogPostGetSingleCommentQuery, BlogPostComment>
        {
            private readonly WebCvDbContext db;

            public BlogPostGetSingleCommentQueryHandler(WebCvDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPostComment> Handle(BlogPostGetSingleCommentQuery request, CancellationToken cancellationToken)
            {
                var data = await db.BlogPostComments
                    .Include(bpc=>bpc.CreatedByUser)
                    .FirstOrDefaultAsync(bpc => bpc.Id == request.Id);

                return data;
            }
        }
    }
}

using MediatR;
using Microsoft.EntityFrameworkCore;
using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebCv.Domain.Business.BlogPostModule
{
    public class BlogPostGetAllDeletedQuery : IRequest<List<BlogPost>>
    {
        public class BlogPostGetAllDeletedHandler : IRequestHandler<BlogPostGetAllDeletedQuery, List<BlogPost>>
        {
            private readonly WebCvDbContext db;

            public BlogPostGetAllDeletedHandler(WebCvDbContext db)
            {
                this.db = db;
            }


            public async Task<List<BlogPost>> Handle(BlogPostGetAllDeletedQuery request, CancellationToken cancellationToken)
            {
                var query = await db.BlogPosts.Where(bp => bp.DeletedDate != null) 
                                             .ToListAsync(cancellationToken);
                return query;
            }
        }
    }
}

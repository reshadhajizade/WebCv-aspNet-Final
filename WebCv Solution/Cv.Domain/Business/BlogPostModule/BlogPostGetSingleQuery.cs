using MediatR;
using Microsoft.EntityFrameworkCore;
using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebCv.Domain.Business.BlogPostModule
{
    public class BlogPostGetSingleQuery : IRequest<BlogPost>
    {
        public int Id { get; set; }
        public string Slug { get; set; }

        public List<BlogPostComment> Comments { get; set; }

        public class BlogPostGetSingleQueryHandler : IRequestHandler<BlogPostGetSingleQuery, BlogPost>
        {
            private readonly WebCvDbContext db;

            public BlogPostGetSingleQueryHandler(WebCvDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPost> Handle(BlogPostGetSingleQuery request, CancellationToken cancellationToken)
            {
                var query = db.BlogPosts
                    .Include(bp => bp.Comments.Where(bpc => bpc.DeletedDate == null))
                    .ThenInclude(c => c.CreatedByUser)

                    .Include(bp => bp.Comments.Where(bpc => bpc.DeletedDate == null))
                    .ThenInclude(c => c.Children.Where(bpc => bpc.DeletedDate == null))
                    .AsQueryable();

                if (string.IsNullOrWhiteSpace(request.Slug))
                {
                    return await query.FirstOrDefaultAsync(bp => bp.Id == request.Id, cancellationToken);

                }
                return await query.FirstOrDefaultAsync(bp => bp.Slug.Equals(request.Slug), cancellationToken);
            }
        }
    }
}

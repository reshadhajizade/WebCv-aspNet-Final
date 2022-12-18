using MediatR;
using Microsoft.EntityFrameworkCore;
using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebCv.Domain.Business.ResumeModule.Bio
{
    public class ResumeBioGetSingleQuery : IRequest<ResumeBio>
    {
        public int Id { get; set; }
        public class BlogPostGetSingleQueryHandler : IRequestHandler<ResumeBioGetSingleQuery, ResumeBio>
        {
            private readonly WebCvDbContext db;

            public BlogPostGetSingleQueryHandler(WebCvDbContext db)
            {
                this.db = db;
            }

            public async Task<ResumeBio> Handle(ResumeBioGetSingleQuery request, CancellationToken cancellationToken)
            {
                var query = await db.ResumeBios.FirstOrDefaultAsync(m => m.Id == request.Id, cancellationToken);
                return query;
            }
        }
    }
}

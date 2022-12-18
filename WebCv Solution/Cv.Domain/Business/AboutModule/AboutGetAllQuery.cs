using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebCv.Domain.Business.AboutModule
{
    public class AboutGetAllQuery : IRequest<List<About>>
    {
        public class AboutGetAllQueryHandler : IRequestHandler<AboutGetAllQuery, List<About>>
        {
            private readonly WebCvDbContext db;

            public AboutGetAllQueryHandler(WebCvDbContext db)
            {
                this.db = db;
            }
            public async Task<List<About>> Handle(AboutGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Abouts
                .Where(bp => bp.DeletedDate == null)
                .ToListAsync(cancellationToken);

                return data;
            }
        }


    }
}

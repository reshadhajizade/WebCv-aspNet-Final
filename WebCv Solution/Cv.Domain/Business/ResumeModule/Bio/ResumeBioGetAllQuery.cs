using MediatR;
using Microsoft.EntityFrameworkCore;
using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebCv.Domain.Business.ResumeModule.Bio
{
    public class ResumeBioGetAllQuery : IRequest<ResumeBio>
    {
        public class ResumeBioGetAllQueryHandler : IRequestHandler<ResumeBioGetAllQuery, ResumeBio>
        {
            private readonly WebCvDbContext db;

            public ResumeBioGetAllQueryHandler(WebCvDbContext db)
            {
                this.db = db;
            }
            public async Task<ResumeBio> Handle(ResumeBioGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeBios.FirstOrDefaultAsync(cancellationToken);
                return data;
            }
        }
    }
}

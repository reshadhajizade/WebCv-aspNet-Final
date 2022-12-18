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

namespace WebCv.Domain.Business.ResumeModule.Diploma
{

    public class ResumeDiplomaGetSingleQuery : IRequest<ResumeDiploma>
    {
        public int Id { get; set; }
        public class ResumeDiplomaGetSingleQueryHandler : IRequestHandler<ResumeDiplomaGetSingleQuery, ResumeDiploma>
        {
            private readonly WebCvDbContext db;

            public ResumeDiplomaGetSingleQueryHandler(WebCvDbContext db)
            {
                this.db = db;
            }

            public async Task<ResumeDiploma> Handle(ResumeDiplomaGetSingleQuery request, CancellationToken cancellationToken)
            {
                var query = await db.ResumeDiplomas.FirstOrDefaultAsync(re => re.Id == request.Id, cancellationToken);
                return query;
            }
        }
    }
}

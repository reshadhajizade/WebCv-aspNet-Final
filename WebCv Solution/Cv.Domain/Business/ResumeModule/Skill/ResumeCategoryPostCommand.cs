using MediatR;
using WebCv.Domain.AppCode.Infrastructure;
using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebCv.Domain.Business.ResumeModule.Skill
{
    public class ResumeCategoryPostCommand : IRequest<JsonResponse>
    {
        public string Name { get; set; }
        public class ResumeCategoryPostCommandHandler : IRequestHandler<ResumeCategoryPostCommand, JsonResponse>
        {
            private readonly WebCvDbContext db;

            public ResumeCategoryPostCommandHandler(WebCvDbContext db)
            {
                this.db = db;
            }
            public async Task<JsonResponse> Handle(ResumeCategoryPostCommand request, CancellationToken cancellationToken)
            {
                var data = new ResumeCategory();
                data.Name = request.Name;
                await db.ResumeCategories.AddAsync(data, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);
                return new JsonResponse
                {
                    Error = false,
                    Message = "Success"
                }; ;
            }
        }
    }
}

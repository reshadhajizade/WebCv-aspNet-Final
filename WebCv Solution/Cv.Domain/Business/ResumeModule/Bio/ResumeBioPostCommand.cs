using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using WebCv.Domain.AppCode.Extensions;
using WebCv.Domain.AppCode.Infrastructure;
using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebCv.Domain.Business.ResumeModule.Bio
{
    public class ResumeBioPostCommand : IRequest<JsonResponse>
    {
        public string Text { get; set; }

        public class ResumeBioPostCommandHandler : IRequestHandler<ResumeBioPostCommand, JsonResponse>
        {
            private readonly WebCvDbContext db;
            public ResumeBioPostCommandHandler(WebCvDbContext db)
            {
                this.db = db;
            }
            public async Task<JsonResponse> Handle(ResumeBioPostCommand request, CancellationToken cancellationToken)
            {
                var entity = new ResumeBio();

                entity.Text = request.Text;

                await db.ResumeBios.AddAsync(entity, cancellationToken);
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

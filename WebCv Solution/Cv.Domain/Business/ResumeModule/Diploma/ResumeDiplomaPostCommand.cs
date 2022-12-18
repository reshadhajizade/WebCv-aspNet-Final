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

namespace WebCv.Domain.Business.ResumeModule.Diploma
{
    public class ResumeDiplomaPostCommand : IRequest<JsonResponse>
    {
        public string Degree { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string Details { get; set; }
        public int YearObtention { get; set; }
        public string UniversityName { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

        public class ResumeDiplomaPostCommandHandler : IRequestHandler<ResumeDiplomaPostCommand, JsonResponse>
        {
            private readonly WebCvDbContext db;
            private readonly IHostEnvironment env;

            public ResumeDiplomaPostCommandHandler(WebCvDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(ResumeDiplomaPostCommand request, CancellationToken cancellationToken)
            {
                var entity = new ResumeDiploma();

                entity.Degree = request.Degree;
                entity.StartYear = request.StartYear;
                entity.EndYear = request.EndYear;
                entity.UniversityName = request.UniversityName;
                entity.YearObtention = request.YearObtention;
                entity.Details = request.Details;


                if (request.Image == null)
                    goto end;

                string extension = Path.GetExtension(request.Image.FileName);

                request.ImagePath = $"diploma-{Guid.NewGuid().ToString().ToLower()}{extension}";
                string fullPath = env.GetImagePhysicalPath(request.ImagePath);

                using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    request.Image.CopyTo(fs);
                }

                entity.ImagePath = request.ImagePath;

            end:
                await db.AddAsync(entity, cancellationToken);
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

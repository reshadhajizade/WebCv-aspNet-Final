using WebCv.Domain.AppCode.Extensions;
using WebCv.Domain.AppCode.Infrastructure;
using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace WebCv.Domain.Business.ProjectsModule
{
    public class ProjectsCreateCommand : IRequest<JsonResponse>
    {
        public string Name { get; set; }

        public string ImagePath { get; set; }
        public string Link { get; set; }

        public int ProjectCategoryId { get; set; }

        public IFormFile Image { get; set; }

        public class ProjectsCreateCommandHandler : IRequestHandler<ProjectsCreateCommand, JsonResponse>
        {
            private readonly WebCvDbContext db;
            private readonly IHostEnvironment env;

            public ProjectsCreateCommandHandler(WebCvDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<JsonResponse> Handle(ProjectsCreateCommand request, CancellationToken cancellationToken)
            {
                var entity = new Project();

                entity.Name = request.Name;
                entity.ProjectCategoryId = request.ProjectCategoryId;
                entity.Link = request.Link;

                if (request.Image == null)
                    goto end;

                string extexsion = Path.GetExtension(request.Image.FileName); 

                request.ImagePath = $"project-{Guid.NewGuid().ToString().ToLower()}{extexsion}";

                string fullPath = env.GetImagePhysicalPath(request.ImagePath);


                using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    request.Image.CopyTo(fs);
                }


                entity.ImagePath = request.ImagePath;

            end:

                await db.Projects.AddAsync(entity, cancellationToken);
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

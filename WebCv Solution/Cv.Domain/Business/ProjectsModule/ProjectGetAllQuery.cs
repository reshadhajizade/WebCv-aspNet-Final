using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebCv.Domain.Business.ProjectsModule
{
    public class ProjectGetAllQuery : IRequest<List<Project>>
    {
        public int ProjectCategoryId { get; set; }

        public class ProjectGetAllQueryHandler : IRequestHandler<ProjectGetAllQuery, List<Project>>
        {
            private readonly WebCvDbContext db;

            public ProjectGetAllQueryHandler(WebCvDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Project>> Handle(ProjectGetAllQuery request, CancellationToken cancellationToken)
            {
                
                var data = await db.Projects
                .Include(p => p.ProjectCategory)
                .Where(p => p.DeletedDate == null)
                .OrderByDescending(p=>p.ProjectCategory)
                .ToListAsync(cancellationToken);

                return data;
            }
        }


    }
}

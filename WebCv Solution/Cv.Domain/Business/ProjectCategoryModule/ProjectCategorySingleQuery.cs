using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.ProjectCategoryModule
{
    public class ProjectCategoryGetSingleQuery : IRequest<ProjectCategory>
    {
        public int Id { get; set; }
        public class ProjectCategorySingleQueryHandler : IRequestHandler<ProjectCategoryGetSingleQuery, ProjectCategory>
        {
            private readonly WebCvDbContext db;

            public ProjectCategorySingleQueryHandler(WebCvDbContext db)
            {
                this.db = db;
            }

            public async Task<ProjectCategory> Handle(ProjectCategoryGetSingleQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ProjectCategories.FirstOrDefaultAsync(p=>p.Id == request.Id);
                    
                return data;
            }
        }

    }
}

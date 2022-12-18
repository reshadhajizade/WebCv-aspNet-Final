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

namespace WebCv.Domain.Business.ProjectCategoryModule
{ 
    public class ProjectCategoryRemoveCommand : IRequest<ProjectCategory>
    {
        public int Id { get; set; }

        public class ProjectCategoryRemoveCommandHandler : IRequestHandler<ProjectCategoryRemoveCommand, ProjectCategory>
        {
            private readonly WebCvDbContext db;

            public ProjectCategoryRemoveCommandHandler(WebCvDbContext db)
            {
                this.db = db;
            }

            public async Task<ProjectCategory> Handle(ProjectCategoryRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = await db.ProjectCategories
                    .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.DeletedDate = DateTime.UtcNow.AddHours(4);
                await db.SaveChangesAsync(cancellationToken);

                return data;
            }


        }
    }
    
}

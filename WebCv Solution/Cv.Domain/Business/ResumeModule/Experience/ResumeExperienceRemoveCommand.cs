using MediatR;
using Microsoft.EntityFrameworkCore;
using WebCv.Domain.Models.DataContexts;
using WebCv.Domain.Models.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace WebCv.Domain.Business.ResumeModule.Experience
{
    public class ResumeExperienceRemoveCommand : IRequest<ResumeExperience>
    {
        public int Id { get; set; }
        public class ResumeExperienceRemoveCommandHandler : IRequestHandler<ResumeExperienceRemoveCommand, ResumeExperience>
        {
            private readonly WebCvDbContext db;

            public ResumeExperienceRemoveCommandHandler(WebCvDbContext db)
            {
                this.db = db;
            }
            public async Task<ResumeExperience> Handle(ResumeExperienceRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeExperiences.FirstOrDefaultAsync(re => re.Id == request.Id && re.DeletedDate ==  null);
                
                if(data == null)
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

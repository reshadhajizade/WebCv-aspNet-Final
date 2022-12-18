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

namespace WebCv.Domain.Business.ResumeModule.Skill
{
    public class ResumeSkillGetAllQuery : IRequest<List<ResumeSkill>>
    {
        public class ResumeSkillGetAllQueryHandler : IRequestHandler<ResumeSkillGetAllQuery, List<ResumeSkill>>
        {
            private readonly WebCvDbContext db;

            public ResumeSkillGetAllQueryHandler(WebCvDbContext db)
            {
                this.db = db;
            }
            public async Task<List<ResumeSkill>> Handle(ResumeSkillGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeSkills.Where(re => re.DeletedDate == null).Include(re=>re.ResumeCategory).ToListAsync(cancellationToken);
                return data;
            }
        }
    }
}

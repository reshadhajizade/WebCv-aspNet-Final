using WebCv.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCv.Domain.Models.Entities
{
    public class ProjectCategory : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Project> Projects { get; set; }

    }
}

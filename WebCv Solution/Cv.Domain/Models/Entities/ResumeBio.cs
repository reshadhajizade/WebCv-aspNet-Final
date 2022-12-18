using WebCv.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCv.Domain.Models.Entities
{
    public class ResumeBio : BaseEntity
    {
        [Required(ErrorMessage = "bosh buraxila bilmez")]
        public string Text { get; set; }
    }
}

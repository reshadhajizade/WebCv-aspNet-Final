using WebCv.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCv.Domain.Models.Entities
{
  public  class ContactPost: BaseEntity
    {
        [Required(ErrorMessage = "{0} bosh buraxila bilmez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "bosh buraxila bilmez")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "bosh buraxila bilmez")]

        public string Subject { get; set; }
        [Required(ErrorMessage = "bosh buraxila bilmez")]

        public string Content { get; set; }
        public string Answer { get; set; }
        public string EmailSubject { get; set; }
        public DateTime? AnswerDate { get; set; }
    }
}

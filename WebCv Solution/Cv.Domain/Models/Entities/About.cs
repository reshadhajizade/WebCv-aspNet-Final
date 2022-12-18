using WebCv.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCv.Domain.Models.Entities
{
    public class About : BaseEntity
    {
        [Required(ErrorMessage = "bosh buraxila bilmez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "bosh buraxila bilmez")]
        public int Age { get; set; }

        [Required(ErrorMessage = "bosh buraxila bilmez")]
        public string Location { get; set; }

        [Required(ErrorMessage = "bosh buraxila bilmez")]
        public int Experince { get; set; }

        public string Degree { get; set; }
        public string CareerLevel { get; set; }

        [Required(ErrorMessage = "bosh buraxila bilmez")]
        public string Phone { get; set; }
        public string Fax { get; set; }

        [Required(ErrorMessage = "bosh buraxila bilmez")]
        public string Email { get; set; }
        public string Website { get; set; }

        [Required(ErrorMessage = "bosh buraxila bilmez")]
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }
}

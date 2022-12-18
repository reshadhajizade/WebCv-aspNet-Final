using WebCv.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume.WebUI.AppCode.ViewComponents.ResumeDiploma
{
    public class ResumeDiplomaViewComponent : ViewComponent
    {
        private readonly WebCvDbContext db;

        public ResumeDiplomaViewComponent(WebCvDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await db.ResumeDiplomas.Where(rd => rd.DeletedDate == null).ToListAsync();

            if (data == null)
            {
                return null;
            }

            return View(await Task.FromResult(data));
        }
    }
}

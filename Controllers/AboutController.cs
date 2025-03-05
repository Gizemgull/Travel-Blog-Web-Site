
using System.Linq;
using System.Web.Mvc;
using Dekorasyon_web.Models.Siniflar;

namespace Dekorasyon_web.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList(); 
            return View(degerler);
        }
    }
}
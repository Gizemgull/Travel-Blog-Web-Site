
using System.Linq;
using System.Web.Mvc;
using Dekorasyon_web.Models.Siniflar;

namespace Dekorasyon_web.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c =new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(4).ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        
        public PartialViewResult Partial4()
        {
            var deger=c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial5()
        {
            var deger=c.Blogs.Take(3).OrderByDescending(x =>x.ID).ToList();
            return PartialView(deger);
        }
    }
}
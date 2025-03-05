
using Dekorasyon_web.Models.Siniflar;
using System.Linq;
using System.Web.Mvc;

namespace Dekorasyon_web.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c =new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            //var bloglar= c.Blogs.ToList();
            by.Deger1= c.Blogs.ToList();
            //by.Deger3 = c.Blogs.Take(3).ToList(); //take(3) mesela 3 tane blogu alsin
            by.Deger3 = c.Blogs.OrderByDescending(y =>y.ID).Take(3).ToList(); //son 3 blog
            return View(by);
        }
       
        public ActionResult BlogDetay(int id)
        {
           // var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
           by.Deger1 = c.Blogs.Where( x => x.ID == id).ToList();
           by.Deger2 = c.Yorumlars.Where( x => x.Blogid == id).ToList();
           return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}
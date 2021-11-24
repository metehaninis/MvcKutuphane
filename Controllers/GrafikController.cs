using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models;

namespace MvcKutuphane.Controllers
{
    public class GrafikController : Controller
    {
        // GET: Grafik
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VisualizeKitapResult()
        {
            return Json(liste()); //bize json değeri içinde liste metodunu geriye döndürecek
        }
        public List<Class1> liste()   //class1 i bir liste formatında liste isimli metot da çağırıyoruz   
        {
            List<Class1> cs = new List<Class1>();   //class1 sınıfından cs isminde nesne türettik
            cs.Add(new Class1()
            {
                yayinevi = "Güneş",
                sayi = 7
            });
            cs.Add(new Class1()
            {
                yayinevi = "Mars",
                sayi = 4
            });
            cs.Add(new Class1()
            {
                yayinevi = "Jupiter",
                sayi = 6
            });
            return cs;
        }
    }
}
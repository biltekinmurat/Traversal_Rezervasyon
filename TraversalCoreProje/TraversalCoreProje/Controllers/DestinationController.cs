using BusinnessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class DestinationController : Controller
    {
        DestinaitonManager destinaitonManager = new DestinaitonManager(new EFDestinationDal());
        public IActionResult Index()
        {
            var values = destinaitonManager.TGetList();
            return View(values);
        }
        public IActionResult DestinationDetail(int id)
        {
            ViewBag.i = id;
            var values = destinaitonManager.TGetByID(id);
            return View(values);
        }
        //[HttpPost]
        //public IActionResult DestinationDetail(Destination p)
        //{
        //    return View();
        //}
    }
}

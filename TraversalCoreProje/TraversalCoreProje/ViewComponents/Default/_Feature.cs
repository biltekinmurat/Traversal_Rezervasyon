using BusinnessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager _featureManager=new FeatureManager(new EFFeatureDal());
        public IViewComponentResult Invoke()
        {
            //var values = _featureManager.TGetList();
            ViewBag.image1 = _featureManager.TGetList()[0];
            ViewBag.image2 = _featureManager.TGetList()[1];
            ViewBag.image3 = _featureManager.TGetList()[2];
            ViewBag.image4 = _featureManager.TGetList()[3];
            ViewBag.image5 = _featureManager.TGetList()[4];

            return View();
        }
    }
}

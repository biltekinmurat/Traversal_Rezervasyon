using BusinnessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
        DestinaitonManager destinaitonManager =new DestinaitonManager(new EFDestinationDal()); 
        public IViewComponentResult Invoke()
        {
            var values = destinaitonManager.TGetList();
            return View(values);
        }
    }
}


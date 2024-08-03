using BusinnessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialManager TestimonialManager=new TestimonialManager(new EFTestiMonialDal());
        public IViewComponentResult Invoke()
        {
            var values = TestimonialManager.TGetList();

            return View(values);
        }
    }
}

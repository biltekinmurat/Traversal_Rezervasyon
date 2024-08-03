using BusinnessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class TestimonialManager: ITestiMonialService
    {
        ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(TestiMonial t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(TestiMonial t)
        {
            throw new NotImplementedException();
        }

        public TestiMonial TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TestiMonial> TGetList()
        {
             return _testimonialDal.GetList();
        }

        public void TUpdate(TestiMonial t)
        {
            throw new NotImplementedException();
        }
    }
}

using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class  //genericdaldan miras almalı ve bu T
                                                                        // class olmalı
    {
        public void Delete(T t)
        {
            var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetList()
        {
            var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            Context c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
        public T GetByID(int id)
        {
            var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }
    }
}

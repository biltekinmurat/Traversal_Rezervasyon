using Microsoft.AspNetCore.Mvc;
using BusinnessLayer.Concrete;
using DataAccesLayer.EntityFramework;

namespace TraversalCoreProje.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager _commentManager = new CommentManager(new EFCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = _commentManager.TGetDestinationById(id);
            return View(values);
        }
    }
}

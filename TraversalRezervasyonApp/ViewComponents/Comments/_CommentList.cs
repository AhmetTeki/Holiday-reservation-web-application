using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.ViewComponents.Comments
{
    public class _CommentList: ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values= commentManager.TGetDestinationById(id);
            return View(values);
        }
    }
}

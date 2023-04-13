using System.Linq;
using System.Security.Cryptography.X509Certificates;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.Comment
{
    public class _CommentList:ViewComponent
    {
       
        public IViewComponentResult Invoke(int id)
        {
            CommentManager commentmanager = new CommentManager(new EFCommentDal());
            Context context= new Context();

            ViewBag.v=context.Comments.Where(x=>x.DestinationID==id).Count();
            var values = commentmanager.GetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}

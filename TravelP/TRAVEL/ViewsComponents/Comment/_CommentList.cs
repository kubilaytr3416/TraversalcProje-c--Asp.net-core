using System.Security.Cryptography.X509Certificates;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.Comment
{
    public class _CommentList:ViewComponent
    {
       
        public IViewComponentResult Invoke(int id)
        {
            CommentManager commentmanager = new CommentManager(new EFCommentDal());

            var values = commentmanager.TGetDestinationById(id);
            return View(values);
        }
    }
}

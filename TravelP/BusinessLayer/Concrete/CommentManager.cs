using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            this._commentDal = commentDal;
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetByID(id);
        }

        public List<Comment> GetList()
        {
            return _commentDal.GetList();
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
        public List<Comment>TGetDestinationById(int id)
        {
            return _commentDal.GetListByFilter(x => x.DestinationID==id);
        }

        public List<Comment> GetListCommentWithDestination()
        {
            return _commentDal.GetListCommentWithDestination();
        }
    }
}

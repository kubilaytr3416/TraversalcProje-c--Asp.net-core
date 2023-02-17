using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutDal
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void Delete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public SubAbout GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> GetList()
        {
           return _subAboutDal.GetList();
        }

        public List<SubAbout> GetListByFilter(Expression<Func<SubAbout, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void Update(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}

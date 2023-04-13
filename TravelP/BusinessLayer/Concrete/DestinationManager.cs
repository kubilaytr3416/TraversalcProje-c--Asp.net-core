using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationalDal;


        public DestinationManager(IDestinationDal destinationalDal)
        {
            _destinationalDal = destinationalDal;
        }

        public Destination GetById(int id)
        {
            return _destinationalDal.GetByID(id);
        }

        public Destination GetDestinationWithGuide(int id)
        {
            return _destinationalDal.GetDestinationWithGuide(id);
        }

        public List<Destination> GetList()
        {
            return _destinationalDal.GetList();
        }

        public void TAdd(Destination t)
        {
            _destinationalDal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            _destinationalDal.Delete(t);
        }

        public List<Destination> TGetLast4Destination()
        {
            return _destinationalDal.GetLast4Destination();
        }

        public void TUpdate(Destination t)
        {
            _destinationalDal.Update(t);
        }
    }
}

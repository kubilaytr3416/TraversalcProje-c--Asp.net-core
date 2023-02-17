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
    public class ReservationManager : IReservationService
    {
        IResevationDal _resevationDal;

        public ReservationManager(IResevationDal resevationDal)
        {
            _resevationDal = resevationDal;
        }

        public Reservation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListApprovalReservation(int id)
        {
            return _resevationDal.GetListByFilter(x => x.AppUserID == id && x.Status=="Onay Bekliyor");
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return _resevationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _resevationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> GetListWithReservationByWaitAprroval(int id)
        {
            return _resevationDal.GetListWithReservationByWaitAprroval(id);

        }

        public void TAdd(Reservation t)
        {
            _resevationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}

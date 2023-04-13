using BusinessLayer.Abstract.AbstractUow;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.UowConcrete
{

    public class AppAccountManager : IAppAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUowDal _uowDal;

        public AppAccountManager(IAccountDal accountDal, IUowDal uowDal)
        {
            _accountDal = accountDal;
            _uowDal = uowDal;
        }

        public AppAccount GetByID(int id)
        {
            return _accountDal.GetByID(id);
        }

        public void Insert(AppAccount t)
        {
            _accountDal.Insert(t);
            _uowDal.Save();
        }

        public void MultiUpdate(List<AppAccount> t)
        {
            _accountDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void Update(AppAccount t)
        {
            _accountDal.Update(t);
            _uowDal.Save();
        }
    }
}

using BusinessLayer.Abstract.AbstractUow;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TRAVEL.Areas.Admin.Models;

namespace TRAVEL.Areas.Admin.Controllers.AppAccountController
{
    [Area("Admin")]
    public class AppAccounController : Controller
    {
        private readonly IAppAccountService _appAccountService;

        public AppAccounController(IAppAccountService appAccountService)
        {
            _appAccountService = appAccountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AppAccountViewModel model)
        {
            var valueSender = _appAccountService.GetByID(model.SenderID);
            var valueReceiver = _appAccountService.GetByID(model.ReceiverID);

            valueSender.Balance -= model.Amount;
            valueReceiver.Balance += model.Amount;

            List<AppAccount> modifiedAccounts = new List<AppAccount>()
            {
                valueSender,
                valueReceiver,
            };

            _appAccountService.MultiUpdate(modifiedAccounts);

            return View();
        }
    }
}

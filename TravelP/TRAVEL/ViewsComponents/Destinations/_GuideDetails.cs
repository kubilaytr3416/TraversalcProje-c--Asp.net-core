﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.Destinations
{
    public class _GuideDetails:ViewComponent
    {
        

        private readonly IGuideService _guideService;
        public _GuideDetails(IGuideService guideService)
        {
            _guideService = guideService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _guideService.GetById(1);
            return View(values);
        }
    }

}


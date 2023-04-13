using System.Collections.Generic;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TRAVEL.Models;

namespace TRAVEL.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.GetList());
            return Json(jsonCity);
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination); ;
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }
        public IActionResult GetById(int DestinationID)
        {
            var values=_destinationService.GetById(DestinationID);
            var jsonValues=JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }
        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.GetById(id);
            _destinationService.TDelete(values);
            return NoContent();
        }
        public IActionResult UpdateCity (Destination destination)
        {
            //var values = _destinationService.GetById(destination.DestinationID);
            //_destinationService.TUpdate(destination);
            //var V = JsonConvert.SerializeObject(destination);
            //return Json(V);
            var values = _destinationService.GetById(destination.DestinationID);
            destination.Status = values.Status;
            destination.Price = values.Price;
            destination.Image = values.Image;
            destination.Description = values.Description;
            destination.Capacity = values.Capacity;
            destination.CoverImage = values.CoverImage;
            destination.Details1 = values.Details1;
            destination.Details2 = values.Details2;
            destination.Image2 = values.Image2;
            _destinationService.TUpdate(destination);
            var V = JsonConvert.SerializeObject(destination);
            return Json(V);



        }
        //public static List<CityClass> cities = new List<CityClass>()
        //{
        //    new CityClass
        //    {
        //        CityID = 1,
        //        CityName = "Üsküp",
        //        CityCountry = "Makedonya"
        //    },
        //     new CityClass
        //    {
        //        CityID = 2,
        //        CityName = "Roma",
        //        CityCountry = "İtalya"
        //    },
        //      new CityClass
        //    {
        //        CityID = 3,
        //        CityName = "Londra",
        //        CityCountry = "İngiltere"
        //    }
        //};

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
    }
}

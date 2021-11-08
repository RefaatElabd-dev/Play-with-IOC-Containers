using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCIOCAutoFac.Filters;
using MVCIOCAutoFac.Repositories;

namespace MVCIOCAutoFac.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IDataRepository _dataRepository;
        private readonly IUserRepository _userRepository;

        public HomeController(IDataRepository dataRepository, IUserRepository userRepository)
        {
            _dataRepository = dataRepository;
            _userRepository = userRepository;
        }

        [LogActionFilter]
        public ActionResult Index()
        {
            var data = _dataRepository.GetData();
            var user = _userRepository.GetData();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using AldoBiturku.RssLibrary;
using AldoBiturku.Web.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AldoBiturku.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public ViewResult Rss()
        {
            //get the rss from library
            RSS rss = new RSS();
            List<RSSModel> listRss = rss.getRSS();

            //map the model
            var rssViewModel = _mapper.Map<List<RSSModel>, List<RSSViewModel>>(listRss);

            return View(rssViewModel .AsQueryable());
        }                             

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

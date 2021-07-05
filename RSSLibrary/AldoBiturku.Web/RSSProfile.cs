using AldoBiturku.RssLibrary;
using AldoBiturku.Web.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AldoBiturku.Web
{
    public class RSSProfile : Profile
    {
        public RSSProfile()
        {
            CreateMap<RSSModel, RSSViewModel>();
        }
    }
}

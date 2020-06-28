using AutoMapper;
using GameStore.BLL.Models.BusinessModels;
using GameStore.WEB.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.WEB.Infrastructure
{
    public class WebMapper : Profile
    {
        public WebMapper()
        {
            CreateMap<LoginViewModel, LoginModel>();
        }
    }
}

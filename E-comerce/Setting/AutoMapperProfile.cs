using AutoMapper;
using E_comerce.Entity;
using E_comerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Setting
{
    public class AutoMapperProfile :Profile 
    {
        public AutoMapperProfile()
        {
            CreateMap<Users, UserModel>();
            CreateMap<RegisterModel, Users>();
        }
    }
}

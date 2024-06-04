﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoodConsluting.Data;

namespace FoodConsluting.Services
{
    public class MapperService : Profile
    {
        CreateMap<Standard, StandardModel>().ReverseMap();
    }
}

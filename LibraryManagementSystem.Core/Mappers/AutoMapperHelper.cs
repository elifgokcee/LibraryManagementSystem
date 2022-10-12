﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Core.Utilities.Mappers
{
    public class AutoMapperHelper
    {
        public static List<T> MapToSameTypeLİst<T>(List<T> list)
        {
            Mapper.Initialize(c => { c.CreateMap<T, T>(); });
            List<T> result = Mapper.Map<List<T>, List<T>>(list);
            return result;
        }

        public static T MapToSameType<T>(T obj)
        {
            Mapper.Initialize(c => { c.CreateMap<T, T>(); });
            T result = Mapper.Map<T, T>(obj);
            return result;
        }
    }
}

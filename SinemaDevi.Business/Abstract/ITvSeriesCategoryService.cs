﻿using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Abstract
{
    public interface ITvSeriesCategoryService
    {
        void Add(TvSeriesCategory tvSeriesCategory);
    }
}
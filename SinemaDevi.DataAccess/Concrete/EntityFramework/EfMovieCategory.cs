﻿using SinemaDevi.DataAccess.Abstract;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.DataAccess.Concrete.EntityFramework
{
    public class EfMovieCategory : EfEntityRepositoryBase<MovieCategory, SinemaDeviDBContext>,IMovieCategory
    {

    }
}

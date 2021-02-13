using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Dtos
{
    public class WatchListMovieDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string CoverImage { get; set; }
        public bool IsActive { get; set; }
    }
}

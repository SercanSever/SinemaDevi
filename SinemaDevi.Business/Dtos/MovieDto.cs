using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        public int Comment { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public System.DateTime Year { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public double ImdbScore { get; set; }
        public string CoverImage { get; set; }
        public string Trailer { get; set; }
        public bool IsActive { get; set; }
    }
}

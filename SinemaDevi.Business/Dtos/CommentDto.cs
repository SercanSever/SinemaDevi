using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Dtos
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int MovieId { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsActive { get; set; }
    }
}

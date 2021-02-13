using SinemaDevi.Business.Dtos;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAll();
        void Add(Comment comment);
        string Count();
        List<Comment> GetTvSeriesId(int id);
        Comment Get(int id);
        List<CommentDto> GetMovieId(int id);
        List<Comment> GetAllStatus();
        void Update(Comment comment);
        List<Comment> GetAllDesc();
    }
}

using SinemaDevi.Business.Abstract;
using SinemaDevi.Business.Dtos;
using SinemaDevi.DataAccess.Abstract;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Concrete
{
    public class CommentManager : ICommentService

    {
        SinemaDeviDBContext _context = new SinemaDeviDBContext();
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }

        public void Add(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public string Count()
        {
            return _commentDal.GetAll().Count().ToString();
        }

        public List<Comment> GetTvSeriesId(int id)
        {
            return _commentDal.GetAll(p => p.TvId == id).Where(p => p.IsActive == true).ToList();
        }

        public Comment Get(int id)
        {
            return _commentDal.Get(p => p.Id == id);
        }

        public List<CommentDto> GetMovieId(int id)
        {
            var list = _context.Database.SqlQuery<CommentDto>($"select u.UserName,c.CreationTime,c.Content from Comment as c inner join Movie as m on c.MovieId = m.Id inner join [User] as u on c.UserId = u.Id  where m.Id = '{id}' and c.IsActive = 1 ").ToListAsync().Result;
            return list;
        }

        public List<Comment> GetAllStatus()
        {
            var context = new SinemaDeviDBContext();
            var query = context.Comments.ToList();
            var result = query.Where(p => p.IsActive == true).ToList();
            return result;
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }

        public List<Comment> GetAllDesc()
        {
            var list = _context.Database.SqlQuery<Comment>("select * from Comment order by Id desc").ToListAsync().Result;
            return list;
        }
    }
}

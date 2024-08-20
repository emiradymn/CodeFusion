using System.Linq;
using CodeFusion.Entity;

namespace CodeFusion.Data.Abstract
{
    public interface ICommentRepository
    {
        IQueryable<Comment> Comments { get; }
        void CreateComment(Comment comment);
    }
}

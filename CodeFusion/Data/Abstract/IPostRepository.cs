using CodeFusion.Entity;
using System.Linq;

namespace CodeFusion.Data.Abstract
{
    public interface IPostRepository
    {
        IQueryable<Post> Posts { get; } // queryable list türü ve postları getirdiğinde ekstra filtreleme yapılıyor.

        void CreatePost(Post post);
        void EditPost(Post post);
        void EditPost(Post post, int[] tagIds);

    }
}

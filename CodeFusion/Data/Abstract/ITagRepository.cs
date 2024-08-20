using CodeFusion.Entity;
using System.Linq;

namespace CodeFusion.Data.Abstract
{
    public interface ITagRepository
    {
        IQueryable<Tag> Tags { get; } // queryable list türü ve postları getirdiğinde ekstra filtreleme yapılıyor.

        void CreatePost(Tag tag);
    }
}

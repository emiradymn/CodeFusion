using CodeFusion.Data.Abstract;
using CodeFusion.Entity;

namespace CodeFusion.Data.Concrete.EfCore
{
    public class EfTagRepository : ITagRepository
    {
        private BlogContext _context;

        public EfTagRepository(BlogContext context)
        {
            _context = context;
        }
        public IQueryable<Tag> Tags => _context.Tags;


        public void CreatePost(Tag tag)
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
        }
    }
}
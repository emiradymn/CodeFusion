using System.Linq;
using CodeFusion.Entity;

namespace CodeFusion.Data.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }
        void CreateUser(User user);
    }
}

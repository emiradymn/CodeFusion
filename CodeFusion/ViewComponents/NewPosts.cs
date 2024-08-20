using CodeFusion.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFusion.ViewComponents
{
    public class NewPosts : ViewComponent
    {
        private IPostRepository _postRepository;

        public NewPosts(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await
                _postRepository
                .Posts
                .OrderByDescending(p => p.PublisedOn)
                .Take(5)
                .ToListAsync());
        }
    }
}
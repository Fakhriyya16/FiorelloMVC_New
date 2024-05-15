using Fiorello_MVC.Data;
using Fiorello_MVC.Models;
using Fiorello_MVC.Services.Interfaces;
using Fiorello_MVC.ViewModels.Blog;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_MVC.Services
{
    public class BlogService : IBlogService
    {
        private readonly AppDbContext _context;
        public BlogService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Blog>> GetAllAsync(int? take = null)
        {
            IEnumerable<Blog> blogs;

            if(take == null)
            {
                blogs = await _context.Blogs.ToListAsync(); 
            }
            else
            {
                blogs = await _context.Blogs.Take((int)take).ToListAsync();
            }
            return blogs.ToList();
        }
        public async Task<Blog> GetByIdAsync(int id)
        {
            Blog blog = await _context.Blogs.FirstOrDefaultAsync(m => m.Id == id);
            return blog;
		}
    }
}

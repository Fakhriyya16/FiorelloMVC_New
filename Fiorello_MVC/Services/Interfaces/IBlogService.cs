using Fiorello_MVC.Models;
using Fiorello_MVC.ViewModels.Blog;

namespace Fiorello_MVC.Services.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GetAllAsync(int? take = null);
        Task<Blog> GetByIdAsync(int id);


	}
}

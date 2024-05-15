using Fiorello_MVC.Models;

namespace Fiorello_MVC.Services.Interfaces
{
    public interface ICategoryService 
    {
        Task<IEnumerable<Category>> GetAllAsync();
    }
}

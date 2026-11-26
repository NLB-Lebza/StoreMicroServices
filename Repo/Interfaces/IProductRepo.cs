using StoreMS.Models;

namespace StoreMS.Repo.Interfaces
{
    public interface IProductRepo
    {
        Task<List<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task<List<Product>> GetByIdAsync(List<int> ids);

        Task AddAsync(Product product);
    }
}

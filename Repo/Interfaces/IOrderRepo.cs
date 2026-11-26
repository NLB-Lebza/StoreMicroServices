using StoreMS.Models;

namespace StoreMS.Repo.Interfaces
{
    public interface IOrderRepo
    {
        Task<List<Order>> GetAllAsync();

        Task<Order?> GetByIdAsync(int id);

        Task AddAsync(Order order);
    }
}

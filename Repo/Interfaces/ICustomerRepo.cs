using StoreMS.Models;


namespace StoreMS.Repo.Interfaces
{
    public interface ICustomerRepo
    {
        Task<List<Customer>> GetAllAsync();

        Task<Customer?> GetByIdAsync(int id);

        Task<bool> EmailExistsAsync(string email);

        Task AddAsync(Customer customer);
    }
}

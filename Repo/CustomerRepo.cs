using StoreMS.Models;
using StoreMS.Data;
using Microsoft.EntityFrameworkCore;
using StoreMS.Repo.Interfaces;

namespace StoreMS.Repo
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;
        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await _context.Customers
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _context.Customers
                .AnyAsync(c => c.Email == email);
        }

        public async Task AddAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }
    }
}

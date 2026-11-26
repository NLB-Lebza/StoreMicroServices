using StoreMS.Models;
using StoreMS.Data;
using Microsoft.EntityFrameworkCore;
using StoreMS.Repo.Interfaces;



namespace StoreMS.Repo
{
    public class IOrder : IOrderRepo
    {
        private readonly AppDbContext _context;
        public IOrder(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetAllAsync()
        {
            return await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Items)
                    .ThenInclude(i => i.Product)
                .ToListAsync();
        }

        public async Task<Order?> GetByIdAsync(int id)
        {
            return await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Items)
                    .ThenInclude(i => i.Product)
                .FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task AddAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }


    }
    }
    
    


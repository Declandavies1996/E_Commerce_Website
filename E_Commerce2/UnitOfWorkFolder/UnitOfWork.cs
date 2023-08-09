using E_Commerce2.DAL;
using E_Commerce2.Data;
using E_Commerce2.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce2.UnitOfWorkFolder
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private IGenericRepository<Product> _products;
        private IGenericRepository<Category> _categories;
        private IGenericRepository<Inventory> _inventory;
        private IGenericRepository<CartItem> _cartItem;
        private IGenericRepository<Order> _order;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Product> Products => _products ??= new GenericRepository<Product>(_context);
        public IGenericRepository<Category> Categories => _categories ??= new GenericRepository<Category>(_context);

        public IGenericRepository<Inventory> Inventory => _inventory ??= new GenericRepository<Inventory>(_context);

        public IGenericRepository<CartItem> CartItems => _cartItem ??= new GenericRepository<CartItem>(_context);

        public IGenericRepository<Order> OrderItems => _order ??= new GenericRepository<Order>(_context);

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

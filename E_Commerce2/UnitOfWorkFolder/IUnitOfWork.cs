using E_Commerce2.DAL;
using E_Commerce2.Data;
using E_Commerce2.Models;

namespace E_Commerce2.UnitOfWorkFolder
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Inventory> Inventory { get; }
        IGenericRepository<CartItem> CartItems { get; }
        IGenericRepository<Order> OrderItems { get; }
        void SaveChanges();
    }
}

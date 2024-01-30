using Book.DataAccess.Data;
using Book.DataAccess.Repository.Interface;
using Book.Models;

namespace Book.DataAccess.Repository.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ICategoryRepository Category {  get; private set; }
        public IProductRepository Product { get; private set; }

        public ICompanyRepository Company { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; set; }
        public IApplicationUserRepository ApplicationUser { get; set; }


        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);

        }

        public void Save()
        {
            _db.SaveChanges();
        }
        public async Task<Company> Get(int id)
        {
            return await Company.GetById(id);
        }
    }
}

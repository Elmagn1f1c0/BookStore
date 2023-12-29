using Movie.DataAccess.Data;
using Movie.DataAccess.Repository.Interface;
using Movie.Models;
using System.Linq.Expressions;

namespace Movie.DataAccess.Repository.Implementation
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
       
        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}

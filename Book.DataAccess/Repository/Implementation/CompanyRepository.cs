using Book.DataAccess.Data;
using Book.DataAccess.Repository.Interface;
using Book.Models;

namespace Book.DataAccess.Repository.Implementation
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}

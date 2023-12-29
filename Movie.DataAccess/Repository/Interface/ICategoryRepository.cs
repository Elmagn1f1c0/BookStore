using Movie.Models;

namespace Movie.DataAccess.Repository.Interface
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}

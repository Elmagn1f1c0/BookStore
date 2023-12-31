namespace Book.DataAccess.Repository.Interface
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        void Save();
    }
}

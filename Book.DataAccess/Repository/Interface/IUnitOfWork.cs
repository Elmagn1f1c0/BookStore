namespace Book.DataAccess.Repository.Interface
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        ICompanyRepository Company { get; }
        void Save();
        
    }
}

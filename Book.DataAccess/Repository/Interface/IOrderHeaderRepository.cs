using Book.Models;

namespace Book.DataAccess.Repository.Interface
{
	public interface IOrderHeaderRepository : IRepository<OrderHeader>
	{
		void Update(OrderHeader obj);
	}
}

﻿using Book.Models;

namespace Book.DataAccess.Repository.Interface
{
	public interface IOrderHeaderRepository : IRepository<OrderHeader>
	{
		void Update(OrderHeader obj);
        void UpdateStatus(int id, string orderStatus, string paymentStatus = null);
        void UpdateStripePaymentID(int id, string sessionId, string paymentIntentId);
    }
}

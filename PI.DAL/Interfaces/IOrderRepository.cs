using PI.DAL.Entities.Orders;

namespace PI.DAL.Interfaces;

public interface IOrderRepository : IBaseRepository<Order>
{
    Task<IEnumerable<Order>> GetByUserIdAsync(Guid userId, CancellationToken ct = default);
    
    Task<Order?> GetWithDetailsAsync(Guid id, CancellationToken ct = default);
}
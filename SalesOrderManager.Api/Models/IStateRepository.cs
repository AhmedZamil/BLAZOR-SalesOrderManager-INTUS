namespace SalesOrderManager.Api.Models
{
    public interface IStateRepository
    {
        IEnumerable<SalesOrderManager.Shared.Domain.State> GetAllStates();
        SalesOrderManager.Shared.Domain.State GetStateById(int stateId);
    }
}

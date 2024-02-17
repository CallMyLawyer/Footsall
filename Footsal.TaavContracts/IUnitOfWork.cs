namespace Footsal.TaavContracts;

public interface IUnitOfWork
{
    Task Begin();
    Task Complete();
    Task Commit();
    Task RollBack();
}
namespace Marraia.SqlServer.Uow.Interfaces
{
    public interface IUnitOfWork
    {
        UnitOfWork BeginTransaction();
    }
}

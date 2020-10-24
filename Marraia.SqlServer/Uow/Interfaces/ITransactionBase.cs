using System.Data;

namespace Marraia.SqlServer.Uow.Interfaces
{
    public interface ITransactionBase
    {
        void AddTransaction(IDbTransaction dbTransaction);
        IDbTransaction GetDbTransaction();
    }
}

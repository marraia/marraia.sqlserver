using Marraia.SqlServer.Uow.Interfaces;
using System.Data;

namespace Marraia.SqlServer.Uow.Transactions
{
    public class TransactionBase : ITransactionBase
    {
        public IDbTransaction DbTransaction { get; private set; }
        public void AddTransaction(IDbTransaction dbTransaction)
        {
            DbTransaction = dbTransaction;
        }

        public IDbTransaction GetDbTransaction()
        {
            return DbTransaction;
        }
    }
}

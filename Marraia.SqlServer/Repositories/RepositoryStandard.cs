using Marraia.SqlServer.Uow.Interfaces;

using System;
using System.Data;

namespace Marraia.SqlServer.Repositories
{
    public abstract class RepositoryStandard<TEntity, TKey> : IDisposable
        where TEntity : class
        where TKey : struct
    {
        protected readonly IDbConnection _connection;
        protected readonly ITransactionBase _transactionBase;

        protected RepositoryStandard(IDbConnection connection,
                                       ITransactionBase transactionBase)
        {
            _connection = connection;
            _connection.Open();

            _transactionBase = transactionBase;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            _connection
                .Close();

            _connection
                .Dispose();
        }
    }
}

using Marraia.SqlServer.Comum;
using Marraia.SqlServer.Core;
using Marraia.SqlServer.Uow.Interfaces;

using System;
using System.Data;

namespace Marraia.SqlServer.Repositories
{
    public abstract class RepositoryStandard<TEntity, TKey> : CommonConfiguration<TEntity>, IDisposable
        where TEntity : Entity<TKey>
        where TKey : struct
    {
        protected readonly IDbConnection _connection;
        protected readonly ITransactionBase _transactionBase;

        protected RepositoryStandard(IDbConnection connection,
                                       ITransactionBase transactionBase)
        {
            _connection = connection;

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

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

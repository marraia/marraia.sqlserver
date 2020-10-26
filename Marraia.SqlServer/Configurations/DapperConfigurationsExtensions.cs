using Marraia.SqlServer.Uow;
using Marraia.SqlServer.Uow.Interfaces;
using Marraia.SqlServer.Uow.Transactions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Marraia.SqlServer.Configurations
{
    public static class DapperConfigurationsExtensions
    {
        public static IServiceCollection AddMarraiaSqlServer(this IServiceCollection service, string connectionString)
        {
            service.AddScoped<IDbConnection>(db => new SqlConnection(connectionString));
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<ITransactionBase, TransactionBase>();

            return service;
        }
    }
}

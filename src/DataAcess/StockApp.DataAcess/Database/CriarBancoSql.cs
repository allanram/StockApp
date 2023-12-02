using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAcess.Database
{
    public static class CriarBancoSql
    {
        public static void Executar()
        {
            var sql = @"
                        IF NOT EXISTS(SELECT * FROM sys.database WHERE name = 'StockApp)
                        BEGIN
                          CREATE DATABASE StockApp

                                 END";
        }

        
    }
}

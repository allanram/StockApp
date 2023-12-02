using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAcess.Database
{
    internal static class SqlServerContext
    {
      
        
            /// <summary>
            /// Propriedade <c>Conexao</c> retorna a string que foi definida no arquivo App.config.
            /// </summary>


            internal static string ConexaoSemBanco => @"Data Source=.\SQLEXPRESS;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";
           internal static string ConexaoComBanco => @"Data Source=.\SQLEXPRESS;Initial Catalog=STOCKELETRO;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";



    }
}

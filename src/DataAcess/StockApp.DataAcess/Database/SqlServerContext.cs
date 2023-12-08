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


            internal static string ConexaoSemBanco => @"server=CEPEAS21104174\SQLEXPRESS;Integrated Security=True;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";
           internal static string ConexaoComBanco => @"server=CEPEAS21104174\SQLEXPRESS;Integrated Security=True;Initial Catalog=StockApp;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";



    }
}

﻿using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAcess.Database
{
    public partial class DataBaseService
    {
        public void CriarTabelaCategoria()
        {
            var sql = @"
                        CREATE TABLE Categorias
                        (
                          Id int,
                          Nome varchar(100)
                        )
                        ";
            try
            {
                using (var conexao = new SqlConnection(SqlServerContext.ConexaoComBanco))
                {
                    //conexao.Open();
                    var resultado = conexao.Execute(sql);
                }
            }
            catch (Exception)
            {

                throw;
            }

            throw new NotImplementedException();
        }
    }
}

using StockApp.Business.Interfaces.Database;
using StockApp.DataAcess.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.WindowsForms._inicializar
{
    internal  class InicializarDataBase
    {
        private  readonly IDataBaseService _dataBaseService;


        public InicializarDataBase() 
        {
            _dataBaseService = new DataBaseService();
        }

        internal void Init() 
        {
            _dataBaseService.CriarBanco();
            _dataBaseService.CriarTabelaCategoria();
        }
    }
}

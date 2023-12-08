using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Business.Interfaces.Database
{
    public interface IDataBaseService
    {
        void CriarBanco();
        void CriarTabelaCategoria();
    }
}

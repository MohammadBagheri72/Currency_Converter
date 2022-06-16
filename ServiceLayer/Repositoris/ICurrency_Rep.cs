using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClass.Currencis_Class;

namespace ServiceLayer.Repositoris
{
   public interface ICurrency_Rep
    {
        IEnumerable<Currencis> GetAllCurrencis();
        int AddCurrency(Currencis currency);
        bool DeleteCurrency(string Id);

    }
}

using DomainClass.Node_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Repositoris
{
   public interface ICurrencyConverter_Rep
    {
        List<Tuple<string, string, double>> GetAllConfig();
        void ClearConfiguration();
        int UpdateConfiguration(Tuple<string, string, double> conversionRates);
        NodeInfo BFSConvert(List<Tuple<string, string, double>> currencyTree,string fromCurrency, string toCurrency, double amount);
    }
}

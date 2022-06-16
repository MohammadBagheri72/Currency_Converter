using DomainClass.Currencis_Class;
using ServiceLayer.Repositoris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
  public  class Currency_Service: ICurrency_Rep
    {
        //  List<Tuple<Guid, string>> CurrencisList = new List<Tuple<Guid, string>>();
        List<Currencis> CurrencisList = new List<Currencis>();

        public IEnumerable<Currencis> GetAllCurrencis()
        {
            return CurrencisList.ToList();
        }
        /// <summary>
        /// 0 is ok 1 is cant added 2 is the name is inuse
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public int AddCurrency(Currencis currency)
        {
            try
            {
                foreach (var item in CurrencisList)
                {
                    if (item.Name == currency.Name)
                    {
                        return 1;
                    }
                }
               
                CurrencisList.Add(currency);
                return 0;
            }
            catch 
            {

                return 2;
            }
           
        }

        public bool DeleteCurrency(string Id)
        {
            ICurrencyConverter_Rep cc = new CurrencyConverter_Service();
            try
            {
                var currency = (from c in CurrencisList
                                where c.ID.ToString().Equals(Id)
                                select c).FirstOrDefault();
                if (currency != null)
                {
                  var lconf=  cc.GetAllConfig();
                    foreach (var item in lconf)
                    {
                        if(item.Item1.Equals(currency.Name) || item.Item2.Equals(currency.Name))
                        {
                            return false;
                        }
                    }
                    CurrencisList.Remove(currency);
                    return true;
                }
                else { return false; }
            }
            catch 
            {

                return false;
            }
           
        }
    }
}

using DomainClass.Node_Class;
using ServiceLayer.Repositoris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CurrencyConverter_Service : ICurrencyConverter_Rep
    {
      public List<Tuple<string, string, double>> configlist = new List<Tuple<string, string, double>>();
        public void ClearConfiguration()
        {
            configlist.Clear();
        }

        /// <summary>
        /// This Function Get List of Tuple and do BFS into this list 
        /// then return MST Rout in result
        /// </summary>
        /// <param name="currencyTree"></param>
        /// <returns></returns>
        public NodeInfo BFSConvert(List<Tuple<string, string, double>> currencyTree,string startNode, string endNode, double amount)
        {
            var blackList = new List<string>();
            var currency_queue = new Queue<NodeInfo>();
            currency_queue.Enqueue(new NodeInfo() { Amount = amount, FinalNode = "", CurrentNode = startNode, Rout = startNode.ToString() });
            blackList.Add(startNode);
           
            for (int i = 0; i < currencyTree.Count(); i++)
            {
                if (currency_queue.Count() == 0)
                {
                    return new NodeInfo() { Amount = 0, FinalNode = startNode };
                }
                var current_item = currency_queue.Dequeue();
                amount = current_item.Amount;
                if (current_item.CurrentNode == endNode)
                {
                    return current_item;
                }
                var find_child = currencyTree.Where(x => x.Item1 == current_item.CurrentNode).ToList();
                foreach (var item in find_child)
                {
                    if (blackList.Where(x => x == item.Item2).Count() == 0)
                    {
                        currency_queue.Enqueue(new NodeInfo() { FinalNode = item.Item1, CurrentNode = item.Item2, Rout = current_item.Rout + "-" + item.Item2, Amount = amount * item.Item3 });
                        blackList.Add(item.Item2);
                    }
                }
            }
            return new NodeInfo() { Amount = 0, FinalNode = startNode };
        }


    public List<Tuple<string, string, double>> GetAllConfig()
        {
            return configlist.ToList();
        }

        /// <summary>
        /// 0 is Added 1 is inuse config 2 is cant added
        /// </summary>
        /// <param name="conversionRates"></param>
        /// <returns></returns>
        public int UpdateConfiguration(Tuple<string, string, double> conversionRates)
        {
            try
            {
                foreach (var item in configlist)
                {
                    if (conversionRates.Item1.Equals(item.Item1) && conversionRates.Item2.Equals(item.Item2))
                    {
                        return 1;
                    }
                }
                configlist.Add(conversionRates);
                return 0;
            }
            catch 
            {

                return 2;
            }
            
        }

        
    }
}

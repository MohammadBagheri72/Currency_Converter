using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using Xunit;


namespace Currency_Converter.Test
{
    public class BFS_CheckValue
    {

        public List<Tuple<string, string, double>> currencyTree = new List<Tuple<string, string, double>>();
        private CurrencyConverter_Service cc = new CurrencyConverter_Service();
        public BFS_CheckValue()
        {
            currencyTree.Add(new Tuple<string, string, double>("usd", "cad", 1.34));
            currencyTree.Add(new Tuple<string, string, double>("cad", "usd", 0.74));
            currencyTree.Add(new Tuple<string, string, double>("cad", "gdr", 0.58));
            currencyTree.Add(new Tuple<string, string, double>("gdr", "cad", 1.74));
            currencyTree.Add(new Tuple<string, string, double>("usd", "eur", 0.86));
            currencyTree.Add(new Tuple<string, string, double>("eur", "usd", 1.16));
        }

        [Fact]
        public void CheckConvertValue_USD_EUR_Rout()
        {
            Assert.Equal("usd-eur", cc.BFSConvert(currencyTree, "usd", "eur", 1000).Rout);
        }

        [Fact]
        public void CheckConvertValue_USD_EUR_Amout()
        {
            Assert.Equal("860", cc.BFSConvert(currencyTree, "usd", "eur", 1000).Amount.ToString());
        }

        [Fact]
        public void CheckConvertValue_USD_EUR_FinalNode()
        {
            Assert.Equal("eur", cc.BFSConvert(currencyTree, "usd", "eur", 1000).FinalNode);
        }
    }
}

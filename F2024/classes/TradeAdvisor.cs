using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Classes
{
    public class TradeAdvisor : ITradeAdvisor
    {
        public string strategy;
        public float[] parameters;

        public void SetAdvisorStrategy(string strategy, float[] parameters)
        {
            this.strategy = strategy;
            this.parameters = parameters;
        }

        public string Update(Share share)
        {
            // Her kan vi implementere den logik, der er nødvendig for at generere en anbefaling baseret på aktiens værdi og strategien
            // Dette er bare et simpelt eksempel:
            if (strategy == "BuyLow")
            {
                return share.Value < parameters[0] ? "Buy" : "Hold";
            }
            else if (strategy == "SellHigh")
            {
                return share.Value > parameters[0] ? "Sell" : "Hold";
            }
            return "Hold";
        }
    }
}
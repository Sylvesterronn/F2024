using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Classes{

    public class Share
    {
        public string Name { get; set; }
        public float Value { get; private set; }
        public ITradeAdvisor TradeAdvisor { get; set; }
        
        private List<Tuple<DateTime, float>> values; // For at gemme tidsstempel og værdi

        public Share(string name, float initialValue)
        {
            Name = name;
            Value = initialValue;
            values = new List<Tuple<DateTime, float>>();
        }

        public void OnStockUpdate(object obj, StockUpdateEventArgs e)
        {
            if (e.ShareName == this.Name)
            {
                AppendValue(e.Time, e.Value);
            }
        }


        public List<Tuple<DateTime, float>> GetValues(int numValues)
        {
            int startIndex = Math.Max(0, values.Count - numValues);
            return values.GetRange(startIndex, values.Count - startIndex);
        }

        public void StartSupervision(ITradeAdvisor tradeAdvisor, string strategy, float[] parameters)
        {
            TradeAdvisor = tradeAdvisor;
            TradeAdvisor.SetAdvisorStrategy(strategy, parameters);
        }
        
        public void AppendValue(DateTime time, float value)
        {
            values.Add(new Tuple<DateTime, float>(time, value));
            Value = value; // Opdater aktieværdien
        }



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes; // Replace 'YourNamespace' with the actual namespace where 'Share' is defined


namespace Interfaces
{
    public interface ITradeAdvisor
    {
        void SetAdvisorStrategy(string strategy, float[] parameters);
        public string Update(Share share);
    }
}
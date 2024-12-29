// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using Interfaces;

// namespace Classes;

// public class LimitAdvisor: ITradeAdvisor
// {
//     private float _thBuy;
//     private float _thSell;

//     public void SetParameters(float float[] parameters)
//     {
//         _thBuy = parameters[0];
//         _thSell = parameters[1];
//     }
    
//     public string GetRecommendation(int value)
//     {
//         if (value < _thBuy)
//         {
//             return "Buy";
//         }
//         else if (value > _thSell)
//         {
//             return "Sell";
//         }
//         else
//         {
//             return "Keep";
//         }
//     }
// }
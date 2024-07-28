using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    public class CPredictiveInventory
    {
        public void ForecastInventory(string predictInventory, string stockId, int Quantity, string sale, string demandInventory, bool Reorder, DateTime LeadTime, string SafetyStock, double cost)
        {
            MPredictInventory predict = new MPredictInventory();
            predict.ForecastInventory(predictInventory, stockId, Quantity, sale, demandInventory, Reorder, LeadTime, SafetyStock, cost);
        }

    }
}

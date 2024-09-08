using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CMarketing
    {
        // Method to add a new marketing
        public void addMarketing(string marketingId, string marketingName, DateTime startDate, DateTime endDate, string type, string USP, double pricing, string FAQs, string contactNumber)
        {
            Marketing addMarket = new Marketing();
            addMarket.addMarketing(marketingId, marketingName, startDate, endDate, type, USP, pricing, FAQs, contactNumber);
        }

        // Method to update an existing marketing
        public void updateMarketing(string marketingId, string marketingName, DateTime startDate, DateTime endDate, string type, string USP, double pricing, string FAQs, string contactNumber)
        {
            Marketing updateMarket = new Marketing();
            updateMarket.updateMarketing(marketingId, marketingName, startDate, endDate, type, USP, pricing, FAQs, contactNumber);
        }

        // Method to delete a marketing
        public void removeMarketing(string marketingId)
        {
            Marketing deleteMarket = new Marketing();

            deleteMarket.removeMarketing(marketingId);
        }
        public DataTable viewMarketing(string marketingId)
        {
            Marketing newMarket = new Marketing();


            return newMarket.viewMarketing(marketingId);
        }
    }
}

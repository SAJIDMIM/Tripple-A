using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CMarketingPromotion
    {
        
        // Method to add a new promotion
        public void addPromotionMarketing(string markPromotionId, string marketingPromotionName, DateTime startDate, DateTime endDate, double discount, string offer, string emailMarketing, string contentMarketing, string inStoreMarketing, string condition)
        {
            MarketingPromotion addPromo = new MarketingPromotion();
            addPromo.addPromotionMarketing(markPromotionId, marketingPromotionName, startDate, endDate, discount, offer, emailMarketing, contentMarketing, inStoreMarketing, condition);
        }

        // Method to update an existing promotion
        public void updatePromotionMarketing(string markPromotionId, string marketingPromotionName, DateTime startDate, DateTime endDate, double discount, string offer, string emailMarketing, string contentMarketing, string inStoreMarketing, string condition)
        {
            MarketingPromotion updatePromo = new MarketingPromotion();
            updatePromo.updatePromotionMarketing(markPromotionId, marketingPromotionName, startDate, endDate, discount, offer, emailMarketing, contentMarketing, inStoreMarketing, condition);
        }

        // Method to delete a promotion
        public void removePromotionMarketing(string markPromotionId)
        {
            MarketingPromotion deletePromo = new MarketingPromotion();

            deletePromo.removePromotionMarketing(markPromotionId);
        }
        public DataTable viewMarketingPromotion(string markPromotion_Id)
        {
            MarketingPromotion newCost = new MarketingPromotion();

         
            return newCost.viewMarketingPromotion(markPromotion_Id);
        }
    }
}

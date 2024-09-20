using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;
namespace Tripple_A_Supermart_Management_System.controller
{
    class CDelivery
    {
        public void addDelivery(string DeliveryId, string deliveryName, string contactNumber, string deliveryAddress, string deliveryType, string availableStatus)
        {
            Delivery newDelivery = new Delivery();
            newDelivery.addDelivery(DeliveryId, deliveryName, contactNumber, deliveryAddress, deliveryType, availableStatus);
        }
        public void updateDelivery(string DeliveryId, string deliveryName, string contactNumber, string deliveryAddress, string deliveryType, string availableStatus)
        {
            Delivery newDelivery = new Delivery();
            newDelivery.updateDelivery(DeliveryId, deliveryName, contactNumber, deliveryAddress, deliveryType, availableStatus);
        }
        public void deleteDelivery(string DeliveryId)
        {
            Delivery newDelivery = new Delivery();
            newDelivery.deleteDelivery(DeliveryId);
        }
        public DataTable searchDelivery(string DeliveryId)
        {
            Delivery newDelivery = new Delivery();
            return newDelivery.searchDelivery(DeliveryId);
        }



    }
}

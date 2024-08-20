using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CTransferItem
    {
        

        public bool transferItem(string itemId, string itemName, string Description, int Quantity, string Category, string recipientEmail)
        {
            // Add any necessary validation or business logic here.
            // For example, you could check if the item ID exists in the database.
            MTransferItem transferItem = new MTransferItem();
            // Call the transferItem method in the model class.
            return transferItem.transferItem(itemId, itemName, Description, Quantity, Category,recipientEmail);
        }
      

    }
}

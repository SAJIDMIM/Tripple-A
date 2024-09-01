using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CItem
    {
        // Assuming there is a model class Item that performs actual item transfer logic

        public bool transferItem(string itemId, string itemName, string description, int quantity, string category, string recipientEmail)
        {
            // Add any necessary validation or business logic here.
            // For example, check if the item ID exists in the database.
            Item itemModel = new Item();  // Use your model class here

            // Call the transferItem method in the model class
            return itemModel.transferItem(itemId, itemName, description, quantity, category, recipientEmail);
        }
    }
}

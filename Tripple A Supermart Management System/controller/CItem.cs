using System;
using System.Data;
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
        public DataTable viewItems(string itemId)
        {
            Item newCost = new Item();


            return newCost.viewItems(itemId);
        }
        public void addItem(string itemId, string itemName, string description, string department, int quantity, double unitPrice, double totalPrice, string category, DateTime manufactureDate, DateTime expiryDate, string manufacturer)
        {
            Item itemModel = new Item();

            itemModel.addItem(itemId, itemName, description, department, quantity, unitPrice, totalPrice, category, manufactureDate, expiryDate, manufacturer);
        }

        public void editItem(string itemId, string itemName, string description, string department, int quantity, double unitPrice, double totalPrice, string category, DateTime manufactureDate, DateTime expiryDate, string manufacturer)
        {
            Item itemModel = new Item();

            itemModel.editItem(itemId, itemName, description, department, quantity, unitPrice, totalPrice, category, manufactureDate, expiryDate, manufacturer);
        }

        public void removeItem(string itemId)
        {
            Item itemModel = new Item();

            itemModel.removeItem(itemId);
        }

        public DataTable viewItem(string itemId)
        {
            Item itemModel = new Item();

            return itemModel.viewItem(itemId);
        }
    }
}

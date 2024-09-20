using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CProduct
    {
        public DataTable viewProducts(string stockId)
        {
            Product showProduct = new Product();


            return showProduct.viewProducts(stockId);
        }
        public void addProduct(string productId, string productName, string category, int quantity, string description, double price)
        {
            Product product = new Product();
            product.addProduct(productId, productName, category, quantity, description, price);
        }

        public void updateProduct(string productId, string productName, string category, int quantity, string description, double price)
        {
            Product product = new Product();
            product.updateProduct(productId, productName, category, quantity, description, price);
        }

        public void removeProduct(string productId)
        {
            Product product = new Product();
            product.removeProduct(productId);
        }

        public DataTable viewProduct(string productId)
        {
            Product product = new Product();
            return product.viewProduct(productId);
        }

    }
}

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
        public DataTable viewProduct(string stockId)
        {
            Product showProduct = new Product();


            return showProduct.viewProduct(stockId);
        }

    }
}

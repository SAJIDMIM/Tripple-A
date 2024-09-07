using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tripple_A_Supermart_Management_System.controller
{
    class CSupplier
    {
        public DataTable viewSupplier(string supplierId)
        {
            model.Supplier viewSupplier = new model.Supplier();
            return viewSupplier.viewSupplier(supplierId);
        }

    }
}

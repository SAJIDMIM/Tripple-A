using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CSupplier
    {
        public DataTable viewSuppliers(string supplierId)
        {
            Supplier viewSupplier = new Supplier();
            return viewSupplier.viewSupplier(supplierId);
        }
        public void addSupplierDetails(string supplierId, string supplierName, string mobile, string company, string productType, DateTime deliverySchedule, string payTerm, string comment)
        {
            Supplier newSupplier = new Supplier();
            newSupplier.addSupplierDetails(supplierId, supplierName, mobile, company, productType, deliverySchedule, payTerm, comment);
        }

        public void updateSupplierDetails(string supplierId, string supplierName, string mobile, string company, string productType, DateTime deliverySchedule, string payTerm, string comment)
        {
            Supplier newSupplier = new Supplier();
            newSupplier.updateSupplierDetails(supplierId, supplierName, mobile, company, productType, deliverySchedule, payTerm, comment);
        }

        public void deleteSupplierDetails(string supplierId)
        {
            Supplier newSupplier = new Supplier();
            newSupplier.deleteSupplierDetails(supplierId);
        }

        public DataTable viewSupplier(string supplierId)
        {
            Supplier newSupplier = new Supplier();
            return newSupplier.viewSupplier(supplierId);
        }

    }
}

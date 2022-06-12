using pharmacyManagementServiceWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pharmacyManagementServiceWebApi.Repository
{
    public interface ISupplierRepository
    {
        SupplierDetail Create(SupplierDetail supplierDetail);
        IEnumerable<SupplierDetail> GetAll();

        SupplierDetail GetSupplier(int id);
        void DeleteSupplier(int id);
        void UpdateSupplier(SupplierDetail supplierDetail);
    }
}

using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface ISupplierService
    {
        List<TblSupplier> GetSupplier();
        TblSupplier GetSupplierById(int Id);
        ResponseModel AddSupplier(TblSupplier info);
        ResponseModel UpdateSupplier(TblSupplier info);
        ResponseModel DeleteSupplier(TblSupplier info);
    }
}

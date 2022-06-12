using pharmacyManagementServiceWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pharmacyManagementServiceWebApi.Repository
{
    public interface IDrugRepository
    {
        DrugDetail Create(DrugDetail drugDetail);
        Task<IEnumerable<DrugDetail>> GetAll();

        DrugDetail GetDrugName(string drugName);
        DrugDetail GetDrug(int id);
        void DeleteDrug(int id);
        void UpdateDrug(DrugDetail drugDetail);
    }
}

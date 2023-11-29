using System.Collections.Generic;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Library.Data_Access
{
    public interface IInventoryData
    {
        List<InventoryModel> GetInventory();
        void SaveInventoryRecord(InventoryModel item);
    }
}
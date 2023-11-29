using System.Collections.Generic;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Library.Data_Access
{
    public interface IProductData
    {
        ProductModel GetProductById(int productId);
        List<ProductModel> GetProducts();
    }
}
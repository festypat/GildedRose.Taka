using GildedRose.Data.Domain;
using GildedRose.Helper.Model;

namespace GildedRose.ApplicationCore.Services
{
    public static class StartTakaService
    {
       
        public static void ProcessItems(this List<ProductItems> productItems)
        {
            if(productItems.Count == 0)
            {
                var data = ProductService.GetItems();

                if (data.Count > 0)
                    data.UpdateItemQuality();
            }
            
            else
            {
                productItems.UpdateItemQuality();
            }
        }
    }
}

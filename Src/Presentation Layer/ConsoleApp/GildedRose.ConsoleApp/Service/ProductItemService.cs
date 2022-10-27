using GildedRose.ApplicationCore.Services;
using GildedRose.Helper.Model;

namespace GildedRose.ConsoleApp.Service
{
    public class ProductItemService
    {
        public void InitiateTakaService()
        {
            var productItems = new List<ProductItems>();
            StartTakaService.ProcessItems(productItems);
        }
    }
}

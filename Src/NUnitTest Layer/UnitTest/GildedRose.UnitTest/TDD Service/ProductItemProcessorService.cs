using GildedRose.ApplicationCore.Services;
using GildedRose.Helper.Model;

namespace GildedRose.UnitTest.TDD_Service
{
    public static class ProductItemProcessorService
    {
        public static ProductItems AndOrUpdateItem(this string name, int sellIn, int quality)
        {
            List<ProductItems> items = new List<ProductItems>
            {
                new ProductItems{ProductName = name, SellIn = sellIn, Quality = quality}
            };

            StartTakaService.ProcessItems(items);
            return items[0];
        }
    }
}

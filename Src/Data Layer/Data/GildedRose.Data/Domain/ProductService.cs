using GildedRose.Helper.Model;

namespace GildedRose.Data.Domain
{
    public class ProductService
    {
        //This service loads data items
        public static List<ProductItems> GetItems()
        {
            return new List<ProductItems>
            {
               new ProductItems { ProductName = "Pat and fes", SellIn = 10, Quality = 20},
               new ProductItems { ProductName = "Aged Brie", SellIn = 2, Quality = 0},
               new ProductItems { ProductName = "Angel and demons", SellIn = 5, Quality = 7},
               new ProductItems { ProductName = "Sulfuras, being a legendary item", SellIn = 0, Quality = 80},
               new ProductItems { ProductName = "Backstage passes to a brussel concert", SellIn = 15,Quality = 20},
               new ProductItems { ProductName = "Conjured all in one", SellIn = 3, Quality = 6}
            };
        }
    }
}

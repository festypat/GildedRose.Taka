using GildedRose.Helper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Data.Domain
{
    public class ProductService
    {
        public static List<ProductItems> GetItems()
        {
            return new List<ProductItems>
            {
               new ProductItems { ProductName = "Pat and fes", SellIn = 10, Quality = 20},
               new ProductItems { ProductName = "Aged Brie", SellIn = 2, Quality = 0},
               new ProductItems { ProductName = "Angel and demons", SellIn = 5, Quality = 7},
               new ProductItems { ProductName = "Sulfuras, Legend", SellIn = 0, Quality = 80},
               new ProductItems { ProductName = "Backstage passes to a brussel concert", SellIn = 15,Quality = 20},
               new ProductItems { ProductName = "Conjured all in one", SellIn = 3, Quality = 6}
            };
        }
    }
}

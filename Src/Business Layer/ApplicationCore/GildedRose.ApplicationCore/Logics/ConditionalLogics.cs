using GildedRose.Helper.Constants;
using GildedRose.Helper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ApplicationCore.Logics
{
    public static class ConditionalLogics
    {
        public static bool EnsureIsAgedBrie(this ProductItems productItem)
        {
            return productItem.ProductName == ProductNameConstants.AgedBrie;
        }

        public static bool EnsureIsBackStagePasses(this ProductItems productItem)
        {
            return productItem.ProductName == ProductNameConstants.BackStage;
        }
        public static bool EnsureIsSulfuras(this ProductItems productItem)
        {
            return productItem.ProductName == ProductNameConstants.Sulfuras;
        }

        public static bool EnsureIsConjured(this ProductItems productItem)
        {
            return productItem.ProductName == ProductNameConstants.Conjured;
        }
    }
}

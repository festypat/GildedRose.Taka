using GildedRose.ApplicationCore.Logics;
using GildedRose.Helper.Constants;
using GildedRose.Helper.Model;

namespace GildedRose.ApplicationCore.Services
{
    public static class ConditionalGroupedLogicService
    {
        public static void ProcessDefault(ProductItems productItem)
        {
            if (DefaultProductLogic.IsDefaultOrConstant(productItem))
            {
                productItem.SellIn--;
                productItem.Quality--;

                if (productItem.SellIn <= 0) productItem.Quality--;

                if (productItem.Quality <= 0) productItem.Quality = 0;
            }
        }

        public static void ProcessAged(ProductItems productItem)
        {
            if (ConditionalLogics.EnsureIsAgedBrie(productItem))
            {
                productItem.SellIn--;
                productItem.Quality++;

                if (productItem.SellIn <= 0) productItem.Quality++;

                if (productItem.Quality > IntegerConstants.MaxQuality)
                    productItem.Quality = IntegerConstants.MaxQuality;
            }
        }

        public static void ProcessBackStagePasses(ProductItems productItem)
        {
            if (ConditionalLogics.EnsureIsBackStagePasses(productItem))
            {
                productItem.SellIn--;
                productItem.Quality++;

                if (productItem.SellIn < IntegerConstants.BackStagePassThresholdOne)
                    productItem.Quality++;

                if (productItem.SellIn < IntegerConstants.BackStagePassThresholdTwo)
                    productItem.Quality++;

                if (productItem.SellIn <= 0) productItem.Quality = 0;

                if (productItem.Quality > IntegerConstants.MaxQuality)
                    productItem.Quality = IntegerConstants.MaxQuality;
            }


        }

        public static void ProcessSulfuras(ProductItems productItem)
        {
            if (ConditionalLogics.EnsureIsSulfuras(productItem))
                productItem.SellIn--;
        }

        public static void ProcessConjured(ProductItems productItem)
        {
            if (ConditionalLogics.EnsureIsConjured(productItem))
            {
                productItem.SellIn--;
                productItem.Quality = productItem.Quality - 2;

                if (productItem.SellIn <= 0) productItem.Quality = productItem.Quality - 2;

                if (productItem.Quality < 0) productItem.Quality = 0;
            }

        }
    }
}

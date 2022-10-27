using GildedRose.Helper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ApplicationCore.Services
{
    public static class GuidedRoseItemsUpdateService
    {
        public static void UpdateItemQuality(this List<ProductItems> productItems)
        {
            for (var i = 0; i < productItems.Count; i++)
            {
                ConditionalGroupedLogicService.ProcessDefault(productItems[i]);

                ConditionalGroupedLogicService.ProcessAged(productItems[i]);

                ConditionalGroupedLogicService.ProcessBackStagePasses(productItems[i]);

                ConditionalGroupedLogicService.ProcessSulfuras(productItems[i]);

                ConditionalGroupedLogicService.ProcessConjured(productItems[i]);
            }
        }
    }
}

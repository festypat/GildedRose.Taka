using GildedRose.Helper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ApplicationCore.Logics
{
    public static class DefaultProductLogic
    {
        public static bool IsDefaultOrConstant(this ProductItems productItem)
        {
            return !(ConditionalLogics.EnsureIsAgedBrie(productItem)
                || ConditionalLogics.EnsureIsBackStagePasses(productItem)
                || ConditionalLogics.EnsureIsSulfuras(productItem)
                || ConditionalLogics.EnsureIsConjured(productItem));
        }
    }
}

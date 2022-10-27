using GildedRose.Helper.Model;

namespace GildedRose.ApplicationCore.Logics
{
    public static class DefaultProductLogic
    {
        //This class validates items names based on an item
        public static bool IsDefaultOrConstant(this ProductItems productItem)
        {
            return !(ConditionalLogics.EnsureIsAgedBrie(productItem)
                || ConditionalLogics.EnsureIsBackStagePasses(productItem)
                || ConditionalLogics.EnsureIsSulfuras(productItem)
                || ConditionalLogics.EnsureIsConjured(productItem));
        }
    }
}

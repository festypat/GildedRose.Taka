using GildedRose.Helper.Constants;
using GildedRose.Helper.Model;

namespace GildedRose.UnitTest.TDD_Service
{
    public class GuidedRoseUnitTestService
    {      

        [Test]
        public void GuildRose_Test_RegularItem_SellInAndQualityLower()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem("foo", 15, 25);

            Assert.That(productItem.SellIn, Is.EqualTo(14));
            Assert.That(productItem.Quality, Is.EqualTo(24));
        }

        [Test]
        public void GuildRose_Test_PastSellInAndQualityDegradedTwiceAsFast()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem("foo", 0, 25);
            Assert.That(productItem.Quality, Is.EqualTo(23));
        }

        [Test]
        public void GuildRose_Test_QualityNever_Negative()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem("foo", 15, 0);
            Assert.That(productItem.Quality, Is.EqualTo(0));
        }

        [Test]
        public void GuildRose_Test_QualityPastSellIn_Never_Negative()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem("foo", -1, 0);
            Assert.That(productItem.Quality, Is.EqualTo(0));
        }

        [Test]
        public void GuildRose_Test_GuidedAgedBrie_Quality_Increases()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.AgedBrie, 15, 25);
            Assert.That(productItem.Quality, Is.EqualTo(26));
        }

        [Test]
        public void GuildRose_Test_GuidedAgedBriePastSellIn_Quality_IncreasesBy2()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.AgedBrie, 0, 25);
            Assert.That(productItem.Quality, Is.EqualTo(27));
        }

        [Test]
        public void GuildRose_Test_GuidedAgedBriePastSellIn_Quality_NeverMoreThan50()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.AgedBrie, 0, 49);
            Assert.That(productItem.Quality, Is.EqualTo(50));
        }

        [Test]
        public void GuildRose_Test_GuidedAgedBrie_Quality_Never_More_Than_50()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.AgedBrie, 15, IntegerConstants.MaxQuality);
            Assert.That(productItem.Quality, Is.EqualTo(50));
        }

        [Test]
        public void GuildRose_Test_GuidedSulfuras_Quality_Never_Decreases()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.Sulfuras, 15, 80);
            Assert.That(productItem.Quality, Is.EqualTo(80));
        }

        [Test]
        public void GuildRose_Test_GuidedSulfurasPastSellIn_Quality_Never_Decreases()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.Sulfuras, -1, 80);
            Assert.That(productItem.Quality, Is.EqualTo(80));
        }

        [Test]
        public void GuildRose_Test_Guided_GivenBackstagePasses_Quality_Increases()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.BackStage, 15, 25);
            Assert.That(productItem.Quality, Is.EqualTo(26));
        }

        [Test]
        public void GuildRose_Test_Guided_GivenBackstagePasses10DaysOut_Quality_IncreasesBy2()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.BackStage, 10, 25);
            Assert.That(productItem.Quality, Is.EqualTo(27));
        }

        [Test]
        public void GuildRose_Test_Guided_GivenBackstagePasses10DaysOut_NeverMoreThan50()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.BackStage, 10, 49);
            Assert.That(productItem.Quality, Is.EqualTo(50));
        }

        [Test]
        public void GuildRose_Test_Guided_GivenBackstagePasses5DaysOut_QualityNeverMoreThan50()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.BackStage, 5, 48);
            Assert.That(productItem.Quality, Is.EqualTo(50));
        }

        [Test]
        public void GuildRose_Test_GivenBackstagePasses5DaysOut_Quality_IncreasesBy3()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.BackStage, 5, 25);
            Assert.That(productItem.Quality, Is.EqualTo(28));
        }

        [Test]
        public void GuildRose_Test_GivenBackstagePassesSellIn_Quality_DropsTo0()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.BackStage, 0, 25);
            Assert.That(productItem.Quality, Is.EqualTo(0));
        }

        [Test]
        public void GuildRose_Test_Conjured_Item_QualityDegradesTwiceAsFast()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.Conjured, 15, 25);
            Assert.That(productItem.Quality, Is.EqualTo(23));
        }

        [Test]
        public void GuildRose_Test_Conjured_PastSellIn_Item_QualityDegradesTwiceAsFast()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.Conjured, 0, 25);
            Assert.That(productItem.Quality, Is.EqualTo(21));
        }

        [Test]
        public void GuildRose_Test_Conjured_QualityNeverNegative()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.Conjured, 15, 0);
            Assert.That(productItem.Quality, Is.EqualTo(0));
        }

        [Test]
        public void GuildRose_Test_Conjured_PastSellIn_QualityNeverNegative()
        {
            ProductItems productItem = ProductItemProcessorService.AndOrUpdateItem(ProductNameConstants.Conjured, 0, 0);
            Assert.That(productItem.Quality, Is.EqualTo(0));
        }
    }
}

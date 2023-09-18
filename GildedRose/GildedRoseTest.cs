using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void Quality_Degrades_Twice_As_Fast([Range(-10, 0)] int sellIn)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "PastSellBy", SellIn = sellIn, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("PastSellBy", Items[0].Name);
            Assert.AreEqual(8, Items[0].Quality);
        }
        
        [Test]
        public void Quality_Degrades_Normally()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "WithinSellBy", SellIn = 1, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("WithinSellBy", Items[0].Name);
            Assert.AreEqual(9, Items[0].Quality);
        }
        
        [Test]
        public void SellIn_Degrades_Normally()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "WithinSellBy", SellIn = 1, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("WithinSellBy", Items[0].Name);
            Assert.AreEqual(0, Items[0].SellIn);
        }
        
        [Test]
        public void Quality_Cannot_Go_Negative()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "WithinSellBy", SellIn = 1, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("WithinSellBy", Items[0].Name);
            Assert.AreEqual(0, Items[0].Quality);
        }
        
        [Test]
        public void Negative_Quality_Does_Not_Change()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "WithinSellBy", SellIn = 1, Quality = -1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("WithinSellBy", Items[0].Name);
            Assert.AreEqual(-1, Items[0].Quality);
        }
        
       
        
        [Test]
        public void Aged_Brie_Quality_Increases_Normally_When_In_SellBy_Date([Range(1, 10)] int sellIn)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = sellIn, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(11, Items[0].Quality);
        }
        
        [Test]
        public void Aged_Brie_Quality_Increases_Twice_As_Fast_When_Out_Of_SellBy_Date([Range(0, -10)] int sellIn)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = sellIn, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(12, Items[0].Quality);
        }
        
        [Test]
        public void Aged_Brie_Quality_Cannot_Go_Above_50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(50, Items[0].Quality);
        }
        
        
        [Test]
        public void Sulfuras_SellIn_Does_Not_Change()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Sulfuras, Hand of Ragnaros", Items[0].Name);
            Assert.AreEqual(1, Items[0].SellIn);
        }
        
        [Test]
        public void Sulfuras_Quality_Does_Not_Change()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Sulfuras, Hand of Ragnaros", Items[0].Name);
            Assert.AreEqual(10, Items[0].Quality);
        }
        
        
        [Test]
        public void Backstage_Passes_Quality_Increases_Twice_As_Fast_When_Above_10_Days_SellBy_Date([Range(11, 20)] int sellIn)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(11, Items[0].Quality);
        }
        
        [Test]
        public void Backstage_Passes_Quality_Increases_By_2_When_Within_10_Days_SellBy_Date([Range(6, 10)] int sellIn)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(12, Items[0].Quality);
        }
        
        [Test]
        public void Backstage_Passes_Quality_Increases_By_3_When_Within_5_Days_SellBy_Date([Range(1, 5)] int sellIn)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(13, Items[0].Quality);
        }
        
        [Test]
        public void Backstage_Passes_Quality_Goes_To_0_When_SellBy_Reaches_0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(0, Items[0].Quality);
        }
    }
}

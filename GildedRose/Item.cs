namespace csharp
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return Name + ", " + SellIn + ", " + Quality;
        }

        internal bool IsQualityLessThan50(Item item)
        {
            return item.Quality < 50;
        }

        internal bool IsSulfuras()
        {
            return Name == "Sulfuras, Hand of Ragnaros";
        }

        internal bool IsBackstagePass()
        {
            return Name == "Backstage passes to a TAFKAL80ETC concert";
        }

        internal bool IsAgedBrie()
        {
            return Name == "Aged Brie";
        }

        internal void DecreaseNormalItemQuality()
        {
                if (Quality > 0)
                {
                    if (!IsSulfuras())
                    {
                        Quality--;
                    }
                }
                
        }
    }
}

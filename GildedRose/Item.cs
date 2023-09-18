namespace csharp
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        internal bool IsQualityLessThan50(Item item)
        {
            return item.Quality < 50;
        }
        
        internal bool IsSulfuras()
        {
            return this.Name == "Sulfuras, Hand of Ragnaros";
        }
        
        internal bool IsBackstagePass()
        {
            return this.Name == "Backstage passes to a TAFKAL80ETC concert";
        }
        
        internal bool IsAgedBrie()
        {
            return this.Name == "Aged Brie";
        }
    }
}

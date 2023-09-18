using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var item = Items[i];
                
                    
                if (item.IsAgedBrie() || item.IsBackstagePass())
                {
                    if (item.IsQualityLessThan50(item))
                    {
                        item.Quality++;

                        if (item.IsBackstagePass())
                        {
                            if (item.SellIn < 11)
                            {
                                if (item.IsQualityLessThan50(item))
                                {
                                    item.Quality++;
                                }
                            }

                            if (item.SellIn < 6)
                            {
                                if (item.IsQualityLessThan50(item))
                                {
                                    item.Quality++;
                                }
                            }
                        }
                    }
                }
                else
                {
                    item.DecreaseNormalItemQuality();
                }

                if (!item.IsSulfuras())
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellIn < 0)
                {
                    if (!item.IsAgedBrie())
                    {
                        if (!item.IsBackstagePass())
                        {
                            item.DecreaseNormalItemQuality();
                        }
                        else
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                    }
                    else
                    {
                        if (item.IsQualityLessThan50(item))
                        {
                            item.Quality++;
                        }
                    }
                }
            }
        }

        
    }
}

namespace csharpcore
{
    public class UpdateProcessFactory {
        public IUpdateProcess GetProcess(Item item)
        {
            if (isAgingItem(item))
            {
                return new AgingItemUpdate();
            }

            if (isLegendaryItem(item))
            {
                return new LegendaryItemUpdate();
            }

            if (isBackstagePass(item))
            {
                return new TicketItemUpdate();
            }

            return new DefaultItemUpdate();
        }

        private bool isAgingItem(Item item)
        {
            return item.Name == "Aged Brie";
        }


        private bool isLegendaryItem(Item item)
        {
            return item.Name == "Sulfuras, Hand of Ragnaros";
        }


        private bool isBackstagePass(Item item)
        {
            return item.Name == "Backstage passes to a TAFKAL80ETC concert";
        }
    }
}
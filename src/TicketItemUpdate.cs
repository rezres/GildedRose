namespace csharpcore
{
    public class TicketItemUpdate : IUpdateProcess {
        public void Update(Item item)
        {
            if (item.Quality < Constants.MaxQuality)
            {
                item.Quality = item.Quality + 1;

                if (item.SellIn < 11)
                {
                    if (item.Quality < Constants.MaxQuality)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }

                if (item.SellIn < 6)
                {
                    if (item.Quality < Constants.MaxQuality)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
namespace csharpcore
{
    public class AgingItemUpdate : IUpdateProcess {
        public void Update(Item item)
        {
            if (item.Quality < Constants.MaxQuality)
            {
                item.Quality = item.Quality + 1;
            }
            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality < Constants.MaxQuality)
                {
                    item.Quality = item.Quality + 1;
                }
            }
        }
    }
}
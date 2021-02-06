namespace csharpcore
{
    public class DefaultItemUpdate : IUpdateProcess {
        public void Update(Item item)
        {
            if (item.Quality > Constants.MinQuality)
            {
                item.Quality = item.Quality - 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality > Constants.MinQuality)
                {
                    item.Quality = item.Quality - 1;
                }
            }
        }
    }
}
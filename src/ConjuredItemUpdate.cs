namespace csharpcore
{
    public class ConjuredItemUpdate : IUpdateProcess {
        public void Update(Item item)
        {
            if (item.Quality - 2 >= Constants.MinQuality)
            {
                item.Quality = item.Quality - 2;
            }
            else
            {
                item.Quality = Constants.MinQuality;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality - 2 >= Constants.MinQuality)
                {
                    item.Quality = item.Quality - 2;
                }
                else
                {
                    item.Quality = Constants.MinQuality;
                }
            }
        }
    }
}
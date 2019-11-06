namespace Iceland.Models
{
    public class BackStagePassRule: Quality, IQualityRule
    {
        /// <inheritdoc/>
        public void Update(Product product)
        {
            product.SellIn--;

            if ((product.SellIn <= 10) && (product.SellIn > 5)) // l0 days or less quality increases by 2
            {
                product.Quality += 2;
            }
            else if ((product.SellIn < 5) && (product.SellIn >= 0)) // 5 days or day of concert quality increases by 3
            {
                product.Quality += 3;
            }
            else if (product.SellIn < 0) //day after concert.
            {
                product.Quality = 0;
            }

            product.Quality = Check(product.Quality);
        }
    }
}
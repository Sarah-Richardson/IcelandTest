namespace Iceland.Models
{
    public class AgedBrieRule: Quality, IQualityRule
    {
        /// <inheritdoc/>
        public void Update(Product product)
        {
            product.SellIn--;

            product.Quality++;

            product.Quality = Check(product.Quality);
        }
    }
}
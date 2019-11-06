namespace Iceland.Models
{
    public class NormalItemRule : Quality, IQualityRule
    {
        /// <inheritdoc/>
        public void Update(Product product)
        {
            product.SellIn--;

            if (product.SellIn > 0)
            {
                product.Quality--;
            }
            else // passed sell in days. 
            {
                product.Quality -= 2;
            }

            product.Quality = Check(product.Quality);
        }
    }
}

namespace Iceland.Models
{
    public class ConjuredRule: Quality, IQualityRule
    {
        /// <inheritdoc/>
        public void Update(Product product)
        {
            product.SellIn--;
            
            if (product.SellIn > 0)
            {
                product.Quality -= 2;
            }
            else // passed sell in date. 
            {
                product.Quality -= 4;
            }

            product.Quality = Check(product.Quality);
        }
    }
}
namespace Iceland.Models
{
    public interface IQualityRule
    {
        /// <summary>
        /// Updates the SellIn and Quality Values.
        /// </summary>
        /// <param name="product"></param>
        void Update(Product product);
    }
}

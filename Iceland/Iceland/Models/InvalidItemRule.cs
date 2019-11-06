
namespace Iceland.Models
{
    public class InvalidItemRule: IQualityRule
    {
        /// <inheritdoc/>
        public void Update(Product product)
        {
            product.Name = "NO SUCH ITEM";
        }
    }
}

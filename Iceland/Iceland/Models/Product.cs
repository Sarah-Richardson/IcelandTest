using System.Runtime.CompilerServices;

namespace Iceland.Models
{
    /// <summary>
    /// Product information.
    /// </summary>
    public class Product
    {
        public enum ProductTypes
        {
            NormalItem,
            AgedBrie,
            BackStagePass,
            Conjured,
            Legendary,
            Invalid
        }

        private IQualityRule _rule;

        /// <summary>
        /// Product type.
        /// </summary>
        private ProductTypes _productType;
        public ProductTypes ProductType
        {
            get => _productType;
            set
            {
                _productType = value;
                _rule = RuleFactory.CreateRule(_productType);
            }

        }

        /// <summary>
        /// Product Name
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// Number of days we have to sell the item.
        /// </summary>
        public int SellIn { get; set; }

        /// <summary>
        /// Quality denotes how valuable the item is.
        /// The quality is never greater than 50.
        /// </summary>
        public int Quality { get; set; }

        /// <summary>
        /// Updates the quality and sell in days based upon the rule.
        /// </summary>
        public void Update()
        {
            _rule.Update(this);
        }
    }
}

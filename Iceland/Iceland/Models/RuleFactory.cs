namespace Iceland.Models
{
    public static class RuleFactory
    {
        /// <summary>
        /// Creates a rule for the given product type.
        /// </summary>
        /// <param name="productType"></param>
        /// <returns></returns>
        public static IQualityRule CreateRule(Product.ProductTypes productType)
        {
            IQualityRule rule = new InvalidItemRule();
            switch (productType)
            {
                case Product.ProductTypes.NormalItem:
                    rule = new NormalItemRule();
                    break;
                case Product.ProductTypes.AgedBrie:
                    rule = new AgedBrieRule();
                    break;
                case Product.ProductTypes.BackStagePass:
                    rule = new BackStagePassRule();
                    break;
                case Product.ProductTypes.Conjured:
                    rule = new ConjuredRule();
                    break;
                case Product.ProductTypes.Legendary:
                    rule = new LegendaryRule();
                    break;
            }

            return rule;
        }
    }
}

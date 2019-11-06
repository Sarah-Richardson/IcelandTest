namespace Iceland.Models
{
    public class Quality
    {
        /// <summary>
        /// Ensures quality is not greater than 50 and not less than zero.
        /// </summary>
        /// <param name="quality"></param>
        /// <returns></returns>
        public int Check(int quality)
        {
            if (quality > 50) quality = 50;
            if (quality < 0) quality = 0;
            return quality;
        }
    }
}

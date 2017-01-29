namespace _10.Price_Change_Alert
{
    using System;

    public class PriceChangeAlert
    {
        public static void Main()
        {
            int numberOfStockPrices = int.Parse(Console.ReadLine());

            double notifyLimit = double.Parse(Console.ReadLine());

            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStockPrices - 1; i++)
            {
                double currenPrice = double.Parse(Console.ReadLine());
                double currentPercentage = GetPercentage(lastPrice, currenPrice);
                bool hasDifference = HasDiffrence(currentPercentage, notifyLimit);

                string message = GetNotofication(currenPrice, lastPrice, currentPercentage, hasDifference);

                Console.WriteLine(message);

                lastPrice = currenPrice;
            }
        }

        public static string GetNotofication(double currentPrice, double lastPrice, double difference, bool hasDifference)
        {
            string total = string.Empty;
            if (difference == 0)
            {
                total = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!hasDifference)
            {
                total = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
            }
            else if (hasDifference && (difference > 0))
            {
                total = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
            }
            else if (hasDifference && (difference < 0))
            {
                total = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
            }

            return total;
        }

        public static bool HasDiffrence(double limit, double notificationLimit)
        {
            if (Math.Abs(limit) >= notificationLimit)
            {
                return true;
            }

            return false;
        }

        public static double GetPercentage(double lastPrice, double currentPrice)
        {
            return (currentPrice - lastPrice) / lastPrice;
        }
    }
}

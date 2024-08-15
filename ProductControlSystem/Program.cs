using ProductControlSystem.Entities;
using System.Globalization;

namespace ProductControlSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int numbersQuantity = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 0; i < numbersQuantity; i++)
            {
                Console.WriteLine($"\nProduct #{i + 1} data:");
                Console.Write("It's a common, used or imported? (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine() ?? "";
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double customsFee;
                DateTime manufactureDate;
                if (productType == 'i')
                {
                    Console.Write("Customs fee: ");
                    customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (productType == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    string manufactureDateString = Console.ReadLine();

                    manufactureDate = ExtractDateTimeFromString(manufactureDateString);
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }

            }

            Console.WriteLine("\n --[ PRICE TAGS ]--");
            products.ForEach(p => Console.WriteLine(p.PriceTag()));
        }

        public static DateTime ExtractDateTimeFromString(string dateTime)
        {
            return DateTime.ParseExact(dateTime, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
    }
}

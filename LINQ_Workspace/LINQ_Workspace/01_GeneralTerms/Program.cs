namespace _01_GeneralTerms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Query Syntax
            //buradaki data source'umuz list
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var querySyntax = from obj in list
                              where obj > 2
                              select obj;
            //query kısmı bitti,
            //şimdi sırada bu query'i execute etme sırası.
            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------"); //sonuçları ayıralım.

            //Method Syntax
            var methodSyntax = list.Where(obj => obj > 2);
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");

            //Mixed Syntax
            var mixedSyntax = (from obj in list select obj).Max();
            Console.WriteLine("Mixed Syntax Max Value Result: " + mixedSyntax);

        }
    }
}
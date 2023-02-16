#region Reverse

namespace _09_SortingOperators_Reverse
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Ali", "Veli", "Guli", "Celi", "Durin" };

            //Method Query
            //var mq = names.Reverse(); //hata alırız. Çünkü bu Reverse() metodu herhangi bir şey döndürmez.

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---");
            var reversed = names.AsEnumerable().Reverse();
            //ya da
            //var reversed = names.AsQueryable().Reverse();

            foreach (var item in reversed)
            {
                Console.WriteLine(item);
            }
        }
    }
}

/*
namespace _09_SortingOperators_Reverse
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Ali", "Veli", "Guli", "Celi", "Durin"};

            //Method Query
            //var mq = names.Reverse(); //hata alırız. Çünkü bu Reverse() metodu herhangi bir şey döndürmez.

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---");
            names.Reverse();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
*/
/*
namespace _09_SortingOperators_Reverse
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Data source'umuz bu array olsun.
            int[] rollNums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Method Syntax

            //var mq = rollNums.Reverse();
            var mq = rollNums.Reverse().ToList();

            //Query Syntax
            //Reverse metodu burada da yok!
            var qsF = from number in rollNums
                     select number;

            //Mixed Syntax ile durumu kurtarabiliriz.
            var qs = (from number in rollNums
                      select number).Reverse().ToList();

            foreach (int item in qs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
*/

#endregion

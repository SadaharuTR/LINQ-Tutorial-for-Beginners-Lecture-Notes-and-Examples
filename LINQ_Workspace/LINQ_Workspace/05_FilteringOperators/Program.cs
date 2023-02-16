
#region Where
/*
namespace _05_FilteringOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Hakan", Email = "hak@gmail.com", Programming =
                new List<Techs>
                {
                    new Techs() { Technology = "C#"},
                    new Techs() { Technology = "SQL"},
                    new Techs() { Technology = "ASP.Net"},
                    new Techs() { Technology = "MVC"}
                }},
                new Employee(){Id = 2, Name = "Serpil", Email = "ser@gmail.com", Programming =
                new List<Techs>
                {
                    new Techs() { Technology = "C++"},
                    new Techs() { Technology = "Bootstrap 5"},
                    new Techs() { Technology = "ASP.Net"},
                }},
                new Employee(){Id = 3, Name = "Sertaç", Email = "tac@gmail.com", Programming =
                new List<Techs>
                {
                    new Techs() { Technology = "C#"},
                    new Techs() { Technology = "MVC"},
                }},
                //aşağıdaki ikisi de yeteneksiz.
                new Employee(){Id = 4, Name = "Ali", Email = "ali@gmail.com", Programming = new List<Techs>()},
                new Employee(){Id = 5, Name = "Gül", Email = "rose@gmail.com", Programming = new List<Techs>()},
            };           
            
            var querySyntax = (from employee in dataSource
                              where employee.Programming.Count > 3
                              && employee.Id == 3
                              select employee).ToList();

            var methodSyntax = dataSource.Where(employee => employee.Programming.Count > 1 || employee.Name == "Serpil").ToList();

            Console.WriteLine("");
        }
    }
}
*/
/*
namespace _05_FilteringOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var querySyntax = (from number in dataSource
                               where number <= 5 || number > 8 //1,2,3,4,5,,9,10
                               select number).ToList();

            var methodSyntax = dataSource.Where(num => num != 4 && num %2 == 0).ToList(); //4 hariç ve 0,6,8,10

            //var dataSource = new List<string>() { "Ali", "Veli", "Hakan", "Mahmutoviç", "Vasilievski" };

            //var querySyntax = (from str in dataSource
            //                   where str.Length > 4 //4 harften uzun kelimeler
            //                   select str).ToList();

            //var querySyntax = (from str in dataSource
            //                   where str.Length > 4  || str == "Ali" //Ali, Hakan, Mahmutoviç, Vasilievski
            //                   select str).ToList();

            //var methodSyntax = dataSource.Where(str => str.Length > 5 || str == "Veli").ToList(); //Veli, Mahmutoviç, Vasilievski

            Console.WriteLine("");
        }
    }
}
*/

/*
namespace _05_FilteringOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = dataSource.Where(num => num > 5).ToList();

            Console.WriteLine("");
        }
    }
}
*/
/*
namespace _05_FilteringOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };  

            var querySyntax = (from number in dataSource
                              where number > 5
                              select number).ToList();

            Console.WriteLine("");
        }
    }
}
*/
#endregion

#region OfType
namespace _05_FilteringOperators
{
    public class Program
    {
        static void Main(string[] args)
        {
            ///object seçmemizin sebebi object içerisinde birden fazla türde veri saklanabilmesidir.
            var dataSource = new List<object>() { "Adem", "Faruk", "Maldonado", 'C', 1, 2, 3, 3.14, 4, 5, (float)9.81 };

            //string verileri alalım
            var methodSyntax = dataSource.OfType<string>().ToList(); //Adem, Faruk ve Maldonado'yu görürüz.
            //int verileri alalım
            var methodSyntax1 = dataSource.OfType<int>().ToList(); //1, 2, 3, 4 ve 5 görürüz.
            //float verileri alalım
            var methodSyntax2 = dataSource.OfType<float>().ToList(); //9.81'i görürüz çünkü float'a cast ettik.
            //char verileri alalım
            var methodSyntax3 = dataSource.OfType<char>().ToList(); //C'yi görürüz.
            //double verileri alalım
            var methodSyntax4 = dataSource.OfType<double>().ToList(); //3.14 görürüz.

            //Query Syntax ile OfType kullanamayız. Fakat aynı işlemi gerçekleştirebiliriz.

            var querySyntax = (from x in dataSource //Adem, Faruk ve Maldonado'yu görürüz.
                               where x is string
                               select x).ToList();

            var querySyntax2 = (from x in dataSource //Adem, Faruk ve Maldonado'yu ayrıca 3.14'ü görürüz.
                                where x is string || x is double
                                select x).ToList();

            //Peki hem türü string olan hem de harf sayısı 5'ten büyük olanları getirmek istersek;
            var methodSyntax5 = dataSource.OfType<string>().Where(x => x.Length > 5).ToList(); //Maldonado döner.
            //burada OfType ile ilk filtreleme işlemini, Where ile de ikinci filtreleme işlemini gerçekleştirdik.

            Console.WriteLine("");
        }
    }
}
#endregion


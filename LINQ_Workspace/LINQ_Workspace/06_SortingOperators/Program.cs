using _06_SortingOperators;

#region OrderBy

namespace _06_SortingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<Employee>()
                    {
                    new Employee() {
                        Id = 3,
                        Email = "ayse@outlook.com",
                        Name = "Ayşe Gül"
                    },
                    new Employee(){
                        Id = 2,
                        Email = "fatma@outlook.com",
                        Name = "Fatmanur"
                    },
                    new Employee(){
                        Id = 1,
                        Email = "andre@outlook.com",
                        Name = "Andre"
                    },
                    new Employee(){
                        Id = 4,
                        Email = "sertac@outlook.com",
                        Name = "Sertaç"
                    }
                };
         

            //Query Syntax
        
            //Id'ye göre sırala.
            var querySyntax = (from emp in dataSource
                              orderby emp.Id
                              select emp).ToList();

            //Name'e göre sırala.
            var querySyntax2 = (from emp in dataSource
                               orderby emp.Name
                               select emp).ToList();
            //Method Syntax

            var methodSyntax = dataSource.OrderBy(emp => emp.Id).ToList();
            var methodSyntax2 = dataSource.OrderBy(emp => emp.Name).ToList();

            //Where filtresi de ekleyelim,

            var querySyntax3 = (from emp in dataSource
                                where emp.Id > 2
                                orderby emp.Name
                                select emp).ToList();
            //Id'si ikiden büyük olanları Name'e göre sırala.
            var methodSyntax3 = dataSource.Where(emp => emp.Id > 2).OrderBy(emp => emp.Name).ToList();

            Console.WriteLine();
        }
    }
}

//Object Example

//String Example
/*
namespace _06_SortingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSourceString = new List<string>() { 
                "Ali",
                "Mehmet",
                "Hakan",
                "Sevim",
                "Fatma",
                "Nurcan",
                "Sevilay" };

            //Query Syntax
            
            var querySyntax = (from name in dataSourceString
                              where name.Length > 5
                              orderby name
                              select name).ToList(); //Mehmet, Nurcan, Sevilay

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item); 
            }

            Console.WriteLine("---");

            //Method Syntax

            var methodSyntax = dataSourceString.Where(name => name.Length > 5).OrderBy(name => name).ToList();
            //Mehmet, Nurcan, Sevilay

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

        }
    }
}
*/
/*
//Example
namespace _06_SortingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };
            
            //Query Syntax
            //where şartları orderby'dan önce yazılmalıdır.
            var querySyntax = (from num in dataSourceInt
                               where num > 10
                               orderby num
                               select num).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item); //12,13,53,100
            }

            Console.WriteLine("-------------");

            //Method Syntax
            //aynı şekilde Where her zaman önce.
            var methodSyntax = dataSourceInt.Where(num => num > 10).OrderBy(num => num).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item); //12,13,53,100
            }

        }
    }
}
*/
/*
//method syntax
namespace _06_SortingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

            var methodSyntax = dataSourceInt.OrderBy(num => num).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
        }
    }
}
*/
//query syntax
/*
namespace _06_SortingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

            var querySyntax = (from num in dataSourceInt
                              orderby num
                              select num).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
        }
    }
}
*/

#endregion

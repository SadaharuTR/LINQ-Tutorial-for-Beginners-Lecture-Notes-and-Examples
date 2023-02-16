
using _07_SortingOperators_OrderByDescending;

#region OrderByDescending

namespace _07_SortingOperators_OrderByDescending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<Employee>()
                    {
                    new Employee() {
                        Id = 3,
                        Email = "ali@outlook.com",
                        Name = "Ali"
                    },
                    new Employee(){
                        Id = 2,
                        Email = "nana@hotmail.com",
                        Name = "Nana"
                    },
                    new Employee(){
                        Id = 1,
                        Email = "andre@yahoo.com",
                        Name = "Andre"
                    },
                    new Employee(){
                        Id = 4,
                        Email = "farhook@gmail.com",
                        Name = "Farook"
                    }
                };


            //Query Syntax

            //Id'ye göre azalan sırada sırala.
            var querySyntax = (from emp in dataSource
                               orderby emp.Id descending
                               select emp).ToList();

            //Name'e göre azalan sırada sırala.
            var querySyntax2 = (from emp in dataSource
                                orderby emp.Name descending
                                select emp).ToList();

            foreach (var item in querySyntax) //Id'ye göre sıralanmış halini ekrana yazdır.
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Email: {item.Email}");
            }

            Console.WriteLine("---");

            foreach (var item in querySyntax2) //Name'e göre sıralanmış halini ekrana yazdır.
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Email: {item.Email}");
            }

            Console.WriteLine("---***---");

            //Method Syntax

            var methodSyntax = dataSource.OrderByDescending(emp => emp.Id).ToList();
            var methodSyntax2 = dataSource.OrderByDescending(emp => emp.Name).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Email: {item.Email}" );
            }

            Console.WriteLine("---");

            foreach (var item in methodSyntax2)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Email: {item.Email}");
            }

            Console.WriteLine("---***---");

            //Where filtresi de ekleyelim,

            var querySyntax3 = (from emp in dataSource
                                where emp.Id > 2
                                orderby emp.Name descending
                                select emp).ToList();

            foreach (var item in querySyntax3)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Email: {item.Email}");
            }

            Console.WriteLine("---");

            //Id'si ikiden büyük olanları Name'e göre sırala.
            var methodSyntax3 = dataSource.Where(emp => emp.Id > 2).OrderBy(emp => emp.Name).ToList();

            foreach (var item in methodSyntax3)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Email: {item.Email}");
            }

            Console.WriteLine();
        }
    }
}

/*
namespace _07_SortingOperators_OrderByDescending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSourceString = new List<string>() { 
                "Ali",
                "Veli",
                "Hakan",
                "Mahmut",
                "Ayse",
                "Aylin",
                "Aysu",
                "Beril"
            };

            //Method Syntax
            var methodSyntax = dataSourceString.OrderByDescending(str => str).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----");

            //Query Syntax'de OrderByDescending yok. Fakat aşağıdaki gibi kullanabiliriz.
            var querySyntax = (from str in dataSourceString
                               orderby str descending
                               select str).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
        }
    }
}
*/
/*
namespace _07_SortingOperators_OrderByDescending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 55, 102 };

            //Method Syntax
            var methodSyntax = dataSourceInt.Where(num => num > 20).OrderByDescending(num => num).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----");

            //Query Syntax'de OrderByDescending yok. Fakat aşağıdaki gibi kullanabiliriz.
            var querySyntax = (from num in dataSourceInt
                               where num > 20
                               orderby num descending
                               select num).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
        }
    }
}
*/
/*
namespace _07_SortingOperators_OrderByDescending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 55, 102};

            //Method Syntax
            var methodSyntax = dataSourceInt.OrderByDescending(num => num).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----");

            //Query Syntax'de OrderByDescending yok. Fakat aşağıdaki gibi kullanabiliriz.
            var querySyntax = (from num in dataSourceInt
                              orderby num descending
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

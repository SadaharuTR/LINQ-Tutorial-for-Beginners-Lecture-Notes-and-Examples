#region SelectMany
namespace _04_ProjectionOperators_SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 adet obje-nesne'ye sahip bir dataSource'umuz olsun.
            var dataSource = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Hakan", Email = "hak@gmail.com", Programming =
                new List<Techs>
                {
                    new Techs() { Technology = "C#"},
                    new Techs() { Technology = "SQL"},
                    new Techs() { Technology = "ASP.Net"},
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
                    new Techs() { Technology = "EF Core"},
                    new Techs() { Technology = "Html 5"},
                }},
                //aşağıdaki ikisi de yeteneksiz.
                new Employee(){Id = 4, Name = "Ali", Email = "ali@gmail.com", Programming = new List<Techs>()},
                new Employee(){Id = 5, Name = "Gül", Email = "rose@gmail.com", Programming = new List<Techs>()},
            };

            //methodQuery'nin List<Techs> türünde olduğunu görürüz.
            //çünkü burada Programming'in türü de List<Techs> 'dir.
            var methodSyntax = dataSource.SelectMany(e => e.Programming).ToList();

            var querySyntax = (from e in dataSource
                               from p in e.Programming
                               select p).ToList();
            //iki syntax ile de 9 kayıt göreceğiz.
            //ve ikisinde de tek bir sequence'a indirilmiş sonucumuzu alacağız.

            foreach (var item in methodSyntax)
            {
                Console.WriteLine("Programming languages: " + item.Technology);
            }

            Console.WriteLine("---");

            foreach (var item in querySyntax)
            {
                Console.WriteLine("Programming languages: " + item.Technology);
            }

            Console.WriteLine();
        }
    }
}
/*
using _04_ProjectionOperators_SelectMany;

namespace LinqSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Kültigin", Email = "kul@gmail.com", Programming = new List<string>(){"Java", "PHP", "C++"} },
                new Employee(){Id = 2, Name = "Gökbörü", Email = "gok@gmail.com", Programming = new List<string>(){"Typescript", "SQL", "Angular"} },
                new Employee(){Id = 3, Name = "Mete", Email = "mete@gmail.com", Programming = new List<string>(){"EF Core", "C#", "Javascript"} }
            };

            var methodSyntax = dataSource.SelectMany(emp => emp.Programming).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine("Programming languages: " + item);
            }

            Console.WriteLine();
        }
    }
}
*/
/*
namespace LinqSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string> { "Cagatay", "Demirtas" };

            var methodResult = strList.SelectMany(x => x).ToList();
            //bütün string'leri tek bir char listesine convert edecektir.

            foreach ( var item in methodResult )
            {
                Console.WriteLine(item);
            }

            var queryResult = (from rec in strList //strList liste halinde string'ler barındırır. Yani bir koleksiyondur.
                              from ch in rec //rec ise buradaki veri kaynağı olarak tek tek string değerleri tutar.
                              select ch).ToList(); //aynı şekilde tüm string'ler artık tek bir char listesine convert edildi.

            Console.Read();
        }
    }
}

*/
#endregion


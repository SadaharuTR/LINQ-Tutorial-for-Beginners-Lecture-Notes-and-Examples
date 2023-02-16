#region ThenBy ve ThenByDescending

namespace _08_SortingOperators_ThenByAndDesc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<Employee>()
            {
                new Employee()
                {
                    Id = 3,
                    Email = "maradona@gmail.com",
                    LastName = "Maradona",
                    FirstName = "Diego Armando"
                },
                new Employee()
                {
                    Id = 2,
                    Email = "pele@gmail.com",
                    LastName = "Pele",
                    FirstName = "Alex"
                },
                new Employee()
                {
                    Id = 1,
                    Email = "alex@gmail.com",
                    LastName = "De Souza",
                    FirstName = "Alex"
                },
                new Employee()
                {
                    Id = 4,
                    Email = "hagi@gmail.com",
                    LastName = "Hagi",
                    FirstName = "Diego Armando"
                }
            };

            //Method Syntax

            //var ms = dataSource.OrderBy(e => e.FirstName).ToList();
            //OrderBy ile artan sırada isimleri, ThenBy ile sıralanmış isimlerin soyisimlerini artan sırada sıralarız.
            var ms = dataSource.OrderBy(e => e.FirstName).ThenBy(e => e.LastName).ToList();

            foreach (var item in ms)
            {
                Console.WriteLine($"{item.Id}, First Name = {item.FirstName}, Last Name = {item.LastName}, E-mail = {item.Email}");
            }

            Console.WriteLine("---");

            //Query Syntax
            //ThenBy bu kullanımda bulunmamakta. Fakat aşağıdaki gibi bir yol bulunabilir.
            //ascending yazmaya gerek yok, default olarak ascending'dir. Fakat azalan sırada olmasını istediğimiz yerde descending yazmalıyız.
            var qs = from e in dataSource
                     orderby e.FirstName ascending, e.LastName descending
                     select e;

            foreach (var item in qs)
            {
                Console.WriteLine($"{item.Id}, First Name = {item.FirstName}, Last Name = {item.LastName}, E-mail = {item.Email}");
            }
        }
    }
}

#endregion

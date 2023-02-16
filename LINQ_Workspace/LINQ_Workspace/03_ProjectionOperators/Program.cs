#region Select
//Aşağıdaki tüm örnekler Select konusuna aittir. (en alttan yukarıya artan zorlukta)

namespace _03_ProjectionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Çağhan", Email = "caghan@gmail.com"},
                new Employee() { Id = 2, Name = "Akay", Email = "akay@gmail.com"},
                new Employee() { Id = 3, Name = "Çağatay", Email = "cagatay@gmail.com"},
                new Employee() { Id = 4, Name = "Bahar", Email = "bahar@gmail.com"},
                new Employee() { Id = 5, Name = "Volkan", Email = "volkan@gmail.com"}
            };

            var query = employees.Select((emp, index) => new { Index = index, FullName = emp.Name }).ToList();

            foreach (var item in query)
            {
                Console.WriteLine($"Index: {item.Index}, Name: {item.FullName}");
            }
        }
    }
}
/*
using _03_ProjectionOperators;

namespace LinqSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Çağhan", Email = "caghan@gmail.com"},
                new Employee() { Id = 2, Name = "Akay", Email = "akay@gmail.com"},
                new Employee() { Id = 3, Name = "Çağatay", Email = "cagatay@gmail.com"},
                new Employee() { Id = 4, Name = "Bahar", Email = "bahar@gmail.com"},
                new Employee() { Id = 5, Name = "Volkan", Email = "volkan@gmail.com"}
            };

            //Anonim olarak oluşturmak için;
            var selectAnonimQuery = (from emp in employees
                               select new
                               {
                                   //artık kendi isimlendirdiğimiz property'leri kullanabiliriz.
                                   CustomId = emp.Id,
                                   AnonimName = emp.Name,
                                   CustomAnonimName = emp.Email
                               }).ToList();
            //selectAnonimQuery'e baktığımızda türünün List<a'> yani anonim olduğunu görürüz.
            foreach (var item in selectAnonimQuery)
            {
                Console.WriteLine($"Id: {item.CustomId}, Name: {item.AnonimName} E-mail: {item.CustomAnonimName}");
            }

            Console.WriteLine("---------------------------");

            //Aynı kodu method syntax ile yazalım.
            var selectAnonimMethod = employees.Select(emp => new
            {
                CustomId = emp.Id,
                AnonimName = emp.Name,
                CustomAnonimName = emp.Email
            });

            foreach (var item in selectAnonimMethod)
            {
                Console.WriteLine($"Id: {item.CustomId}, Name: {item.AnonimName} E-mail: {item.CustomAnonimName}");
            }
        }
    }
}
*/

/*
using _03_ProjectionOperators;

namespace LinqSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Çağhan", Email = "caghan@gmail.com"},
                new Employee() { Id = 2, Name = "Akay", Email = "akay@gmail.com"},
                new Employee() { Id = 3, Name = "Çağatay", Email = "cagatay@gmail.com"},
                new Employee() { Id = 4, Name = "Bahar", Email = "bahar@gmail.com"},
                new Employee() { Id = 5, Name = "Volkan", Email = "volkan@gmail.com"}
            };

            //employees içindeki verileri Student() sınıfından property'lere atayarak alalım. 
            //Artık selectQuery <Student> türünden bir List olacaktır.
            var selectQuery = (from emp in employees
                               select new Student()
                               {
                                   StudentId = emp.Id,
                                   FullName = emp.Name,
                                   StEmail= emp.Email
                               }).ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine($"Id: {item.StudentId}, Name: {item.FullName} E-mail: {item.StEmail}");
            }

            var selectMethod = employees.Select(emp => new Student()
            {
                StudentId = emp.Id,
                FullName = emp.Name,
                StEmail = emp.Email
            }).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine($"Id: {item.StudentId}, Name: {item.FullName} E-mail: {item.StEmail}");
            }
        }
    }
}
*/
/*
using _03_ProjectionOperators;

namespace LinqSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Çağhan", Email = "caghan@gmail.com"},
                new Employee() { Id = 2, Name = "Akay", Email = "akay@gmail.com"},
                new Employee() { Id = 3, Name = "Çağatay", Email = "cagatay@gmail.com"},
                new Employee() { Id = 4, Name = "Bahar", Email = "bahar@gmail.com"},
                new Employee() { Id = 5, Name = "Volkan", Email = "volkan@gmail.com"}
            };

            //hepsini seçmek zorunda değiliz. Employee() içindeki name hariç diğer sütunları da seçebiliriz.
            var selectQuery = (from emp in employees
                                  select new Employee()
                                  {
                                      Id = emp.Id,
                                      Email = emp.Email
                                  }).ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name} E-mail: {item.Email}");
            }

        }
    }
}
*/
/*
using _03_ProjectionOperators;

namespace LinqSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Çağhan", Email = "caghan@gmail.com"},
                new Employee() { Id = 2, Name = "Akay", Email = "akay@gmail.com"},
                new Employee() { Id = 3, Name = "Çağatay", Email = "cagatay@gmail.com"},
                new Employee() { Id = 4, Name = "Bahar", Email = "bahar@gmail.com"},
                new Employee() { Id = 5, Name = "Volkan", Email = "volkan@gmail.com"}
            };
            
            //Query Syntax
            var basicPropQuery = (from emp in employees
                                  select emp.Id.ToString()).ToList();
            
            foreach (var item in basicPropQuery)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------");

            //Method Syntax

            var basicPropMethod = employees.Select(emp => emp.Id.ToString()).ToList();

            foreach (var item in basicPropMethod) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
*/

/*
using _03_ProjectionOperators;

namespace LinqSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Çağhan", Email = "caghan@gmail.com"},
                new Employee() { Id = 2, Name = "Akay", Email = "akay@gmail.com"},
                new Employee() { Id = 3, Name = "Çağatay", Email = "cagatay@gmail.com"},
                new Employee() { Id = 4, Name = "Bahar", Email = "bahar@gmail.com"},
                new Employee() { Id = 5, Name = "Volkan", Email = "volkan@gmail.com"}
            };
            
            //tüm datayı seçmek için;
            //var basicQuery = from emp in employees
            //                 select emp;
            

            //Query Syntax
            var basicQuery = (from emp in employees
                              select emp).ToList();
            //ToList ile execute etmiş oluyoruz. ToList() ile koleksiyona çevirerek elde ederiz.

            //basicQuery'nin içinde Employee türünde 5 adet objemiz olduğunu görürüz. Bu objeler select kısmında herhangi bir
            ////manipülasyona uğramadığı için orjinal formundadır.
            foreach (var item in basicQuery)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
            }

            Console.WriteLine("----------");

            //Method Syntax

            //Herhangi bir operasyon uygulamacağımız için Select metodunu kullanmamıza gerek yoktur. Direkt olarak
            //ToList() kullanabiliriz.
            var basicMethod = employees.ToList();

            foreach (var item in basicMethod)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
            }
            //Sonuç tamamen aynı olacaktır.
        }
    }
}

*/
#endregion

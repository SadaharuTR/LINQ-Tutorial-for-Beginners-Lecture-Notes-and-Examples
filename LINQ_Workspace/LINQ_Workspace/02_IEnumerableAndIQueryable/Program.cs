#region Example
/*
namespace LinqSample1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            //var querySyntax = from obj in list
            //                  where obj > 2
            //                  select obj;
            //burada mouse'umuzu querySyntax'ın üzerinde tıklamadan tuttuğumuzda türünün "IEnumerable generic type int" olduğunu görürüz.
            

            //ve bu şekilde yazdığımızda herhangi bir hata ile karşılamayız.
            IEnumerable<int> querySyntax = from obj in list
                                           where obj > 2
                                           select obj;

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
        }
    }
}
*/
#endregion

#region IEnumerable
/*
namespace LinqSample1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Ali" },
                new Employee() { Id = 2,Name = "Hakan"}
            };

            IEnumerable<Employee> query = from emp in employees
                                          where emp.Id == 1
                                          select emp;

            foreach (var item in query)
            {
                Console.WriteLine("Id : " + item.Id + "'e sahip şahsın adı: " + item.Name);
            }

        }
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}

*/
#endregion

#region IQueryable
/*
namespace LinqSample1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Ali" },
                new Employee() { Id = 2,Name = "Hakan"}
            };

            IQueryable<Employee> query1 = employees.AsQueryable().Where(X => X.Id == 1);

            foreach (var item in query1)
            {
                Console.WriteLine("Id : " + item.Id + "'e sahip şahsın adı: " + item.Name);
            }
        }
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}

*/
#endregion



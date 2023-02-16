#region Inner Join
/*
namespace _14_JoinOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>() 
            {
                new Student() { Id = 1, Name = "Balin", AddressId = 1 },
                new Student() { Id = 2, Name = "Durin", AddressId = 0 },
                new Student() { Id = 3, Name = "Kili", AddressId = 2 },
                new Student() { Id = 4, Name = "Thorin", AddressId = 0 },
                new Student() { Id = 5, Name = "Bifur", AddressId = 3 }
            };

            var addresses = new List<Address>()
            {
                new Address() { Id = 1, AddressLine = "Line 1" },
                new Address() { Id = 2, AddressLine = "Line 2" },
                new Address() { Id = 3, AddressLine = "Line 3" },
                new Address() { Id = 4, AddressLine = "Line 4" },
                new Address() { Id = 5, AddressLine = "Line 5" }
            };

            //Query Syntax

            var qs = (from student in students //outer'dan
                     join address in addresses //birleştirilecek tabloya doğru
                     on student.AddressId equals address.Id //aynı şekilde on .... equals
                     select new 
                     { 
                         StudentName = student.Name,
                         Line = address.AddressLine
                     }).ToList();

            //Method Syntax

            var ms = students.Join(addresses,
                                    std => std.AddressId,
                                    address => address.Id,
                                    (std, address) => new
                                    {
                                        StudentName = std.Name,
                                        Line = address.AddressLine
                                    }).ToList();

            foreach(var a in qs)
            {
                Console.WriteLine($"Student Name: {a.StudentName} / Address: {a.Line}");
            }

            Console.WriteLine("---");

            foreach (var a in ms)
            {
                Console.WriteLine($"Student Name: {a.StudentName} / Address: {a.Line}");
            }

            Console.WriteLine("---");

            //Where Şartlı Sorgular
            var msWhere = students.Join(addresses,
                                    std => std.AddressId,
                                    address => address.Id,
                                    (std, address) => new
                                    {
                                        StudentName = std.Name,
                                        Line = address.AddressLine
                                    }).Where(a => a.StudentName.Length > 4).ToList();

            var qsWhere = (from student in students //outer'dan
                      join address in addresses //birleştirilecek tabloya doğru
                      on student.AddressId equals address.Id //aynı şekilde on .... equals
                      where student.Name.Length > 4 
                      select new
                      {
                          StudentName = student.Name,
                          Line = address.AddressLine
                      }).ToList();

            foreach (var a in msWhere)
            {
                Console.WriteLine($"Student Name: {a.StudentName} / Address: {a.Line}");
            }

            Console.WriteLine("---");

            foreach (var a in qsWhere)
            {
                Console.WriteLine($"Student Name: {a.StudentName} / Address: {a.Line}");
            }

            Console.WriteLine();
        }
    }
}
*/
#endregion

#region Inner Join Multiple Data Sources
/*
namespace _14_JoinOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student() { Id = 1, Name = "Balin", AddressId = 1 },
                new Student() { Id = 2, Name = "Durin", AddressId = 0 },
                new Student() { Id = 3, Name = "Kili", AddressId = 2 },
                new Student() { Id = 4, Name = "Thorin", AddressId = 0 },
                new Student() { Id = 5, Name = "Bifur", AddressId = 3 }
            };

            var addresses = new List<Address>()
            {
                new Address() { Id = 1, AddressLine = "Line 1" },
                new Address() { Id = 2, AddressLine = "Line 2" },
                new Address() { Id = 3, AddressLine = "Line 3" },
                new Address() { Id = 4, AddressLine = "Line 4" },
                new Address() { Id = 5, AddressLine = "Line 5" }
            };

            var marks = new List<Marks>()
            {
                new Marks() { Id = 1, StudentId = 1, TMarks = 80 },
                new Marks() { Id = 2, StudentId = 2, TMarks = 90 },
                new Marks() { Id = 3, StudentId = 3, TMarks = 95 },
            };

            //Query Syntax

            var qs = (from student in students //outer'dan
                      join address in addresses //birleştirilecek tabloya doğru
                      on student.AddressId equals address.Id //aynı şekilde on .... equals
                      join mark in marks
                      on student.Id equals mark.StudentId
                      select new
                      {
                          StudentName = student.Name,
                          Line = address.AddressLine,
                          TotalMarks = mark.TMarks
                      }).ToList();

            //Method Syntax

            var ms = students.Join(addresses,std => std.AddressId, address => address.Id, (std, address) => new {std, address})
                                    .Join(marks, student => student.std.Id, m => m.StudentId, (student, m) => new {student, m})
                                    .Select(x => new
                                    {
                                        StudentName = x.student.std.Name,
                                        Line = x.student.address.AddressLine,
                                        TotalMarks = x.m.TMarks
                                    }).ToList();

            foreach (var a in qs)
            {
                Console.WriteLine($"Student Name: {a.StudentName} / Address: {a.Line} and Mark is: {a.TotalMarks}");
            }

            Console.WriteLine("---");

            foreach (var a in ms)
            {
                Console.WriteLine($"Student Name: {a.StudentName} / Address: {a.Line} and Mark is: {a.TotalMarks}");
            }
        }
    }
}
*/
#endregion

#region Group Join
/*
using System.Xml.Linq;

namespace _14_JoinOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<StudentGroup>()
            {
                new StudentGroup() { Id = 1, Name = "Ali", CategoryId = 1 },
                new StudentGroup() { Id = 2, Name = "Murat", CategoryId = 1 },
                new StudentGroup() { Id = 3, Name = "Sevinç", CategoryId = 2 },
                new StudentGroup() { Id = 4, Name = "Aysel", CategoryId = 2 },
                new StudentGroup() { Id = 5, Name = "Nurdan", CategoryId = 3 }
            };

            var categories = new List<CategoryGroup>()
            {
                new CategoryGroup() { Id = 1, Name = "Gaming PC"},
                new CategoryGroup() { Id = 2, Name = "Monitor"},
                new CategoryGroup() { Id = 3, Name = "Mouse"}
            };

            //Method Syntax
            var ms = categories.GroupJoin(students, cat => cat.Id, std => std.CategoryId,
                (cat, std) => new { cat, std}
                );

            foreach ( var item in ms ) //categories
            {
                Console.WriteLine(item.cat.Name + " ->");

                foreach (var c in item.std) //all records belong to categories
                {
                    Console.WriteLine(c.Name);
                }
            }

            Console.WriteLine("---");

            //Query Syntax
            var qs = from c in categories
                     join std in students on c.Id equals std.CategoryId into stdGroups
                     select new { c, stdGroups };

            foreach (var item in qs) //categories
            {
                Console.WriteLine(item.c.Name + " ->");

                foreach (var c in item.stdGroups) //all records belong to categories
                {
                    Console.WriteLine(c.Name);
                }
            }
        }
    }
    class StudentGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }

    class CategoryGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
*/
#endregion

#region Left Join
using System.Xml.Linq;

namespace _14_JoinOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<StudentLeft>()
            {
                new StudentLeft() { Id = 1, Name = "Ali", AddressId = 1 },
                new StudentLeft() { Id = 2, Name = "Murat", AddressId = 2 },
                new StudentLeft() { Id = 3, Name = "Sevinç"},
                new StudentLeft() { Id = 4, Name = "Aysel", AddressId = 3 },
                new StudentLeft() { Id = 5, Name = "Nurdan", AddressId = 5 }
            };

            var address = new List<AddressLeft>()
            {
                new AddressLeft() { Id = 1, AddressLine = "Ali'nin adresi."},
                new AddressLeft() { Id = 2, AddressLine = "Murat'ın adresi."},
                new AddressLeft() { Id = 3, AddressLine = "Aysel'in adresi."}
            };

            //Query Syntax
            var qs = (from std in students
                     join add in address on std.AddressId equals add.Id into stdAddress
                     from studentAddress in stdAddress.DefaultIfEmpty() //null dönmesi için 
                     select new { StudentName = std.Name,StudentAddress = studentAddress != null ? studentAddress.AddressLine : "NA" }).ToList();

            foreach ( var item in qs )
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---");

            //Method Syntax
            var ms = students.GroupJoin(address, std => std.AddressId, add => add.Id,
                                       (std, add) => new { std, add }
                                        ).SelectMany(x => x.add.DefaultIfEmpty(), (studentData, addressData) => new { studentData.std, addressData });          

            Console.WriteLine();
        }
    }
    class StudentLeft
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
    }

    class AddressLeft
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }
    }
}
#endregion


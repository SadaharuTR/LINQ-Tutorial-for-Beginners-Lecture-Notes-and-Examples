#region Distinct

//Örnek
/*
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace _11_SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>()
            {
                new Student() {Id = 1, Name = "John"},
                new Student() {Id = 2, Name = "Mike"},
                new Student() {Id = 1, Name = "John"},
                new Student() {Id = 4, Name = "Marki"},
            };

            //Değişikliklerden sonra tekrar çalıştıralım,
            var ms = students.Distinct(new StudentComparer()).ToList();
            Console.WriteLine();

        }
    }
}
*/

/*
// Örnek
namespace _11_SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>()
            {
                new Student() {Id = 1, Name = "John"},
                new Student() {Id = 2, Name = "Mike"},
                new Student() {Id = 3, Name = "John"},
                new Student() {Id = 4, Name = "Mike"},
            };

            //Method Syntax
            //Distinct Name'leri elde etmek için,
            var ms = students.Select(x => x.Name).Distinct().ToList();
            //John ve Mike'dan oluşan 2 kişilik bir liste gelir.
            Console.WriteLine();
        }
    }
}
*/

/*
 * IEquatable çözümü için,
class Student : IEquatable<Student>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public bool Equals(Student? other)
    {
        if(object.ReferenceEquals(other, null)) //iki referans farklıysa
            return false;
        if(object.ReferenceEquals(this, other)) //iki referans'da aynıysa
            return true;

        return Id.Equals(other.Id) && Name.Equals(other.Name);
    }

    public override int GetHashCode()
    {
        int idHashCode = Id.GetHashCode();
        int nameHashCode = Name.GetHashCode();

        return idHashCode^ nameHashCode;
    }

}
*/
/*
//IEqualityComparer çözümü için,
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

}

class StudentComparer : IEqualityComparer<Student>
{
    public bool Equals(Student? x, Student? y)
    {
        return x.Id.Equals(y.Id) && x.Name.Equals(y.Name);
    }

    public int GetHashCode(Student obj)
    {
        int idHashCode = obj.Id.GetHashCode();
        int nameHashCode = obj.Name.GetHashCode();

        return idHashCode ^ nameHashCode;
    }
}
*/
/*
//Örnek
namespace _11_SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 3, 4, 5, 5, 5, 5, 5, 6, 7, 8, 9, 9, 10 };

            //Method Syntax
            //var ms = numbers.Distinct();
            //şu anda bu sorgu execute edilmemiştir. IEnumerable döndürmektedir. Execute etmek için;

            var ms = numbers.Distinct().ToList();
            //debug modunda çalıştırıp ms'in içine baktığımızda 1,2,3,4,5,6,7,8,9,10'u tekli sonuçlar olarak görürüz.

            //Query Syntax
            var qs = (from num in numbers
                      select num).Distinct().ToList(); //Aynı şekilde execute etmek için Tolist()
            //debug modunda çalıştırıp qs'in içine baktığımızda da 1,2,3,4,5,6,7,8,9,10'u tekli sonuçlar olarak görürüz.

            Console.WriteLine();

        }
    }
}
*/
#endregion

#region Except
/*
//Örnek
namespace _11_SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> datasource1 = new List<string>() { "A", "B", "C", "D" };
            List<string> datasource2 = new List<string>() { "C", "D", "E", "F" };

            //Method Syntax
            var ms = datasource1.Except(datasource2).ToList();
            //A ve B
            Console.WriteLine();

        }
    }
}
*/
/*
namespace _11_SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>()
            {
                new Student() {Id = 1, Name = "Serkan"},
                new Student() {Id = 2, Name = "Çağhan"},
                new Student() {Id = 3, Name = "Eylül"},
                new Student() {Id = 4, Name = "Murat"}
            };

            List<Student> students1 = new List<Student>()
            {
                new Student() {Id = 1, Name = "Serkan"},
                new Student() {Id = 2, Name = "Çağhan"},
                new Student() {Id = 5, Name = "Mart"},
                new Student() {Id = 6, Name = "Muro"}
            };

            var ms = students.Select(x => x.Name).Except(students1.Select(x => x.Name)).ToList();
            //Eylül ile Murat döner.

            var ms1 = students.Except(students1).ToList();
            //4 kaydı da elde ettik. Ama etmememiz gerekiyordu?

            //Anonim Tip yardımıyla tüm property'leri seçerek çözebiliriz.
            var ms2 = students.Select(x => new {x.Id, x.Name}).Except(students1.Select(x => new {x.Id, x.Name})).ToList();
            //Eylül ile Murat

            Console.WriteLine();
        }
    }
}
*/
/*
namespace _11_SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>()
            {
                new Student() {Id = 1, Name = "Serkan"},
                new Student() {Id = 2, Name = "Çağhan"},
                new Student() {Id = 3, Name = "Eylül"},
                new Student() {Id = 4, Name = "Murat"}
            };

            List<Student> students1 = new List<Student>()
            {
                new Student() {Id = 1, Name = "Serkan"},
                new Student() {Id = 2, Name = "Çağhan"},
                new Student() {Id = 5, Name = "Mart"},
                new Student() {Id = 6, Name = "Muro"}
            };

            var ms = students.Except(students1, new StudentComparer()).ToList();
            //Eylül ile Murat

            //Query - Mixed
            var qs = (from std in students
                      select std).Except(students1, new StudentComparer()).ToList();
            //Eylül ile Murat
            Console.WriteLine();

        }
    }
}
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

}

class StudentComparer : IEqualityComparer<Student>
{
    public bool Equals(Student? x, Student? y)
    {
        return x.Id.Equals(y.Id) && x.Name.Equals(y.Name);
    }

    public int GetHashCode(Student obj)
    {
        int idHashCode = obj.Id.GetHashCode();
        int nameHashCode = obj.Name.GetHashCode();

        return idHashCode ^ nameHashCode;
    }
}
*/
#endregion

#region Intersect
/*
namespace _11_SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> datasource1 = new List<string>() { "A", "B", "C", "D" };
            List<string> datasource2 = new List<string>() { "C", "D", "E", "F" };

            //Method Syntax
            var ms = datasource1.Intersect(datasource2).ToList();
            //C ve D

            //Query Syntax - Mixed
            var qs = (from ch in datasource1
                      select ch).Intersect(datasource2).ToList();
            Console.WriteLine();
        }
    }
}
*/
/*
namespace _11_SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students1 = new List<Student>()
            {
                new Student() {Id = 1, Name = "Serkan"},
                new Student() {Id = 2, Name = "Çağhan"},
                new Student() {Id = 3, Name = "Eylül"},
                new Student() {Id = 4, Name = "Murat"}
            };

            List<Student> students2 = new List<Student>()
            {
                new Student() {Id = 1, Name = "Serkan"},
                new Student() {Id = 2, Name = "Çağhan"},
                new Student() {Id = 5, Name = "Mart"},
                new Student() {Id = 6, Name = "Muro"}
            };

            //Anonim Tip Yöntemi
            var ms = students1.Select(x => new {x.Id, x.Name}).Intersect(students2.Select(x => new { x.Id, x.Name})).ToList();
            //Serkan ve Çağhan

            Console.WriteLine();

        }
    }
}
*/
/*
namespace _11_SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students1 = new List<Student>()
            {
                new Student() {Id = 1, Name = "Serkan"},
                new Student() {Id = 2, Name = "Çağhan"},
                new Student() {Id = 3, Name = "Eylül"},
                new Student() {Id = 4, Name = "Murat"}
            };

            List<Student> students2 = new List<Student>()
            {
                new Student() {Id = 1, Name = "Serkan"},
                new Student() {Id = 2, Name = "Çağhan"},
                new Student() {Id = 5, Name = "Mart"},
                new Student() {Id = 6, Name = "Muro"}
            };

            //Comparer Yöntemi
            var ms = students1.Intersect(students2, new StudentComparer()).ToList();
            //Serkan ve Çağhan

            Console.WriteLine();

        }
    }
}
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}
class StudentComparer : IEqualityComparer<Student>
{
    public bool Equals(Student? x, Student? y)
    {
        return x.Id.Equals(y.Id) && x.Name.Equals(y.Name);
    }

    public int GetHashCode(Student obj)
    {
        int idHashCode = obj.Id.GetHashCode();
        int nameHashCode = obj.Name.GetHashCode();

        return idHashCode ^ nameHashCode;
    }
}
*/
#endregion

#region Union
/*
 * Örnek
namespace _11_SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> datasource1 = new List<string>() { "A", "A", "C", "D" };
            List<string> datasource2 = new List<string>() { "C", "D", "E", "F" };

            //Method Syntax
            var ms = datasource1.Union(datasource2).ToList();
            //"A", "C", "D", "E", "F" 

            //Query Syntax - Mixed
            var qs = (from ch in datasource1
                      select ch).Union(datasource2).ToList();
            Console.WriteLine();

        }
    }
}
*/
/*
namespace _11_SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students1 = new List<Student>()
            {
                new Student() {Id = 1, Name = "Serkan"},
                new Student() {Id = 2, Name = "Çağhan"},
                new Student() {Id = 3, Name = "Eylül"},
                new Student() {Id = 4, Name = "Murat"}
            };

            List<Student> students2 = new List<Student>()
            {
                new Student() {Id = 1, Name = "Serkan"},
                new Student() {Id = 2, Name = "Çağhan"},
                new Student() {Id = 5, Name = "Mart"},
                new Student() {Id = 6, Name = "Muro"}
            };

            //Method Syntax

            //Yanlış yazım;
            //var ms = students1.Union(students2).ToList();

            //Doğru yazım;
            var ms = students1.Union(students2, new StudentComparer()).ToList();
            //Yine Comparer Yöntemi ile çözdük. Tekrar eden kayıtlar harici 6 adet kayıt elde ettik.

            //Anonim Tip Yöntemi
            var msA = students1.Select(x => new { x.Id, x.Name }).Union(students2.Select(x => new {x.Id, x.Name})).ToList();

            Console.WriteLine();
        }
    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class StudentComparer : IEqualityComparer<Student>
{
    public bool Equals(Student? x, Student? y)
    {
        return x.Id.Equals(y.Id) && x.Name.Equals(y.Name);
    }

    public int GetHashCode(Student obj)
    {
        int idHashCode = obj.Id.GetHashCode();
        int nameHashCode = obj.Name.GetHashCode();

        return idHashCode ^ nameHashCode;
    }
}
*/
#endregion
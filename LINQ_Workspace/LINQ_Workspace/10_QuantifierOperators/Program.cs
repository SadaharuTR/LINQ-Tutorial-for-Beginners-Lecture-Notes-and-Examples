#region All
/*
namespace _10_QuantifierOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student
                {
                    Name = "Remzi", Yoklama = 90,
                    Subject = new List<Subject>() {
                        new Subject { subjectName = "Matematik", subjectPoints = 75 },
                        new Subject { subjectName = "Japonca", subjectPoints = 80 },
                        new Subject { subjectName = "Tarih", subjectPoints = 75 },
                        new Subject { subjectName = "Cografya", subjectPoints = 72 }
                } },
                new Student
                {
                    Name = "Naz", Yoklama = 80,
                    Subject = new List<Subject>() {
                        new Subject { subjectName = "Matematik", subjectPoints = 55 },
                        new Subject { subjectName = "Japonca", subjectPoints = 60 },
                        new Subject { subjectName = "Tarih", subjectPoints = 95 },
                        new Subject { subjectName = "Cografya", subjectPoints = 100 }
                } },
                new Student
                {
                    Name = "Nur", Yoklama = 50,
                    Subject = new List<Subject>() {
                        new Subject { subjectName = "Matematik", subjectPoints = 75 },
                        new Subject { subjectName = "Japonca", subjectPoints = 90 },
                        new Subject { subjectName = "Tarih", subjectPoints = 85 },
                        new Subject { subjectName = "Cografya", subjectPoints = 90 }
                } },
            };

            //Method Syntax

            //Tüm derslerinden 70 üstü puan almış öğrenci bul.
            var studentS = students.Where(std => std.Subject.All(x => x.subjectPoints > 70)).Select(std => std).ToList();
            //Remzi ve Nur

            //Query Syntax

            //Tüm derslerinden 70 üstü puan almış öğrenci bul.
            var qs = (from std in students
                     where std.Subject.All(x => x.subjectPoints > 70)
                     select std).ToList();
            //Remzi ve Nur
            Console.WriteLine();
        }
    }
}
class Student
{
    public string Name { get; set; }
    public int Yoklama { get; set; }

    public List<Subject> Subject { get; set; }
}

class Subject
{
    public string subjectName { get; set; }
    public int subjectPoints { get; set; }
}
*/
/*
namespace _10_QuantifierOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student { Name = "Dilber", Point = 90 },
                new Student { Name = "Yasin", Point = 80 },
                new Student { Name = "Tolga", Point = 75 },
            };

            //Query Syntax'da All metodu yok?
            //Çare Mixed Syntax
            var q = (from student in students
                     select student).All(x => x.Point > 70);

            Console.WriteLine(q); //True
        }
    }
}
*/
/*
namespace _10_QuantifierOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student { Name = "Dilber", Point = 90 },
                new Student { Name = "Yasin", Point = 80 },
                new Student { Name = "Tolga", Point = 75 },
            };

            //Tüm öğrenciler 70 puanı geçmiş mi?
            var query = students.All(student => student.Point > 70);
            Console.WriteLine(query); //True
        }
    }
}
*/
#endregion

#region Any
/*
namespace _10_QuantifierOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student
                {
                    Name = "Mahmut", Yoklama = 90,
                    Subject = new List<Subject>()
                    {
                        new Subject() { subjectName = "Matematik", subjectPoints = 75},
                        new Subject() { subjectName = "Fransızca", subjectPoints = 80},
                        new Subject() { subjectName = "Sanat Tarihi", subjectPoints = 86},
                        new Subject() { subjectName = "Beden Eğitimi", subjectPoints = 71},
                    }
                },
                new Student
                {
                    Name = "Sertac", Yoklama = 80,
                    Subject = new List<Subject>()
                    {
                        new Subject() { subjectName = "Matematik", subjectPoints = 65},
                        new Subject() { subjectName = "Fransızca", subjectPoints = 90},
                        new Subject() { subjectName = "Sanat Tarihi", subjectPoints = 96},
                        new Subject() { subjectName = "Beden Eğitimi", subjectPoints = 91},
                    }
                },
                new Student
                {
                    Name = "Sevilay", Yoklama = 70,
                    Subject = new List<Subject>()
                    {
                        new Subject() { subjectName = "Matematik", subjectPoints = 95},
                        new Subject() { subjectName = "Fransızca", subjectPoints = 70},
                        new Subject() { subjectName = "Sanat Tarihi", subjectPoints = 66},
                        new Subject() { subjectName = "Beden Eğitimi", subjectPoints = 81},
                    }
                }
            };

            //Method Syntax
            //Herhangi bir notu 70'den yüksek olan öğrencileri bulalım. Üç öğrenci de bulunur.
            var ms = students.Where(std => std.Subject.Any(x => x.subjectPoints > 70)).Select(std => std.Name).ToList();
            ////Herhangi bir notu 90'dan yüksek olan öğrencileri bulalım. Sertac ve Sevilay bulunur.
            var ms1 = students.Where(std => std.Subject.Any(x => x.subjectPoints > 90)).Select(std => std.Name).ToList();
            
            //Query Syntax
            var qs = (from std in students
                     where std.Subject.Any(x => x.subjectPoints > 91)
                     select std).ToList(); //Sertac ve Sevilay'ın 91'in üstünde en az 1 notu var.

            Console.WriteLine();
        }
    }
}
*/
/*
namespace _10_QuantifierOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            if (numbers.Any())            
                Console.WriteLine("içi dolu bir liste");            
            else
            Console.WriteLine("iç boş bir liste");

            //ya da

            if (numbers.Count() > 0)
                Console.WriteLine("içi dolu bir liste");      
            else
                Console.WriteLine("iç boş bir liste");            
        }
    }
}
*/
/*
namespace _10_QuantifierOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {1,2,3,4,5};

            //numbers list'inde herhangi bir eleman var mı?
            var isAvailable = numbers.Any();
            Console.WriteLine(isAvailable); //true
        }
    }
}
*/
/*
namespace _10_QuantifierOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            //numbers list'inde herhangi bir eleman var mı?
            var isAvailable = numbers.Any();
            Console.WriteLine(isAvailable); //false
        }
    }
}
*/
/*
class Student
{
    public string Name { get; set; }
    public int Yoklama { get; set; }

    public List<Subject> Subject { get; set; }
}

class Subject
{
    public string subjectName { get; set; }
    public int subjectPoints { get; set; }
}
*/
#endregion

#region Contains

using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace _10_QuantifierOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() 
            { 
                new Student() { Id = 1, Name = "Olivier Mira Armstrong"},
                new Student() { Id = 2, Name = "Balalaika"}
            };

            //var isExist = students.Contains(new Student() { Id = 1, Name = "Olivier Mira Armstrong" }); //false döndü?
            //Çünkü Contains metodu object'ler için referansı kontrol eder, değeri etmez. Yukarıda tanımlanan iki object'in referansları farklıdır.

            //Bunu çözmek için;

            //var std = new Student() { Id = 1, Name = "Olivier Mira Armstrong" };
            //students.Add(std);
            //var isExist = students.Contains(std); //true döndü ama artık 3 elemanımız var.
            //Yine tam olarak çözemedik...
            //---

            //Artık oldu gibi...

            //Method Syntax
            var comparer = new StudentComparer();

            var isExist = students.Contains(new Student() { Id = 1, Name = "Olivier Mira Armstrong" }, comparer);
            //true dönecektir.

            foreach (var item in students)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Method synxtax ile: " + isExist);
            //Query Syntax ile, daha doğrusu Mixed Syntax ile;
            var qs = (from std in students
                      select std).Contains(new Student() { Id = 1, Name = "Olivier Mira Armstrong" }, comparer);
            Console.WriteLine("Query synxtax ile: " + qs);

        }
    }
}

/*
namespace _10_QuantifierOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>() {"Cagatay", "Ahmet", "Goku", "Vegeta"};
            //İlk Kullanım
            //Method Syntax
            var isExist = students.AsEnumerable().Contains("Ahmet"); //true
            var isExist1 = students.AsEnumerable().Contains("Sertac"); //false
            //Query Syntax
            var isExistQuery = (from student in students
                                select student).Contains("Goku"); //true
            var isExistQuery1 = (from student in students
                                select student).Contains("Vegetarian"); //false
            Console.WriteLine();
        }
    }
}
*/
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class StudentComparer : IEqualityComparer<Student>
{
    public bool Equals(Student x, Student y)
    {
        if (object.ReferenceEquals(x, y)) //referans'lar aynıysa true dön.
        {
            return true;
        }
        if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y,null)) //birinden biri null ise false dön.
        {
            return false;
        }
        return x.Id == y.Id && x.Name == y.Name; //en sonda da tüm property'leri tasdikleyelim.
    }

    public int GetHashCode(Student obj)
    {
        if (Object.ReferenceEquals(obj, null))
        {
            return 0;
        }
        int idHashCode = obj.Id.GetHashCode();
        int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();

        return idHashCode ^ nameHashCode;
    }
}

#endregion


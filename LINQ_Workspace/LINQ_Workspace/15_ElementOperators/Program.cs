
#region ElementAt ve ElementAtOrDefault
/*
namespace _15_ElementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };

            //Method Syntax
            var ms = numbers.ElementAt(1); //2
            var ms1 = numbers.ElementAt(8); //9
            //var ms2 = numbers.ElementAt(10); //System.ArgumentOutOfRangeException
            ////var ms3 = numbers.ElementAt(-1); //System.ArgumentOutOfRangeException
            
            var msD = numbers.ElementAtOrDefault(1); //2
            var msD1 = numbers.ElementAtOrDefault(6);//7
            var msD2 = numbers.ElementAtOrDefault(-1); //Listemizin türüne göre default değer hangisiyse onu döndürür.
            //Yani burada 0 değerini görürüz.

            List<string> names = new List<string>() { "Ali", "Trantod", "Markuziski"};

            var msS0 = names.ElementAtOrDefault(2); //Markuziski
            var msS1 = names.ElementAtOrDefault(10); //null, çünkü string'de referans türlü bir değişkendir.

            //Mixed Syntax

            var mixedS = (from n in numbers
                          select n).ElementAt(2); //3

            var mixedS1 = (from n in names
                           select n).ElementAt(1); //Trantod

            //Filtreleme işlemleri ekleyelim.

            var msF = numbers.Where(x => x > 3).ElementAtOrDefault(1);
            //5 değerini alacaktır. Çünkü filtre ile ile ilk üç değeri atladık. Oradan itibaren 0. ve 1. index olarak sayar.
            Console.WriteLine();
        }
    }
}
*/
#endregion

#region First ve FirstOrDefault
/*
 * Örnek
namespace _15_ElementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Method Syntax
            var ms = numbers.First(); //1
           
            var msF = numbers.Where(x => x % 2 == 0).First(); //2
            //ya da
            var msF1 = numbers.First(x => x % 2 == 0); //2 şeklinde de yazılabilir. Bu yöntem daha hızlı olduğu için daha çok tercih edilmelidir.

            var msF2 = numbers.Where(x => x % 2 == 0).First(x => x > 2); //4 (bir deneyeyim dedim. Kötü bir kullanım.)

            //var msErr = numbers.Where(x => x > 10).First(); //System.InvalidOperationException

            var msFoD = numbers.Where(x => x > 10).FirstOrDefault(); //0 döner.

            List<string> names = new List<string>() { "Ali", "Trantod", "Markuziski" };

            var msS = names.First(); //Ali

            var msSF = names.Where(name => name.Length > 3).First(); //Trantod

            var msFoDS = names.Where(x => x.Length > 10).FirstOrDefault(); //null

            Console.WriteLine();
           
        }
    }
}
*/
/*
using System.Security.Cryptography;

namespace _15_ElementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>()
            { 
                new User() { Id = 1, UserName = "Admin", Password = "Admin"},
                new User() { Id = 2, UserName = "User1", Password = "User1"},
                new User() { Id = 3, UserName = "User2", Password = "User2"},
                new User() { Id = 4, UserName = "User3", Password = "User3"}
            };

            var ms = users.First(x => x.UserName == "Admin" && x.Password == "Admin");
            var msFD = users.FirstOrDefault(x => x.UserName == "Admin" && x.Password == "Admin"); //1 Id'li objeyi dönerler.

            //var msF = users.First(x => x.UserName == "Admin" && x.Password == "Admin123"); //Error

            var msFoD = users.FirstOrDefault(x => x.UserName == "Admin" && x.Password == "Admin123"); //Null

            //Mixed Syntax

            var mixedS = (from user in users
                            select user).FirstOrDefault(x => x.UserName == "Admin" && x.Password == "Admin"); //1 Id'li objeyi döner.

            var mixedS1 = (from user in users
                          select user).FirstOrDefault(x => x.UserName == "User2" && x.Password == "User2"); //3 Id'li,

            var mixedS2 = (from user in users
                          select user).FirstOrDefault(x => x.UserName == "User3" && x.Password == "User3"); //4 Id'li objeyi döner.

            Console.WriteLine();
        }
    }
}
class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
*/
#endregion

#region Last ve LastOrDefault
/*
 * Örnek
using System.Security.Cryptography;

namespace _15_ElementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Method Syntax
            var ms = numbers.Last(); //10

            var msF = numbers.Where(x => x < 8).Last(); //7
            //ya da
            var msF1 = numbers.Last(x => x < 8); //7 şeklinde de yazılabilir. Bu yöntem daha hızlı olduğu için daha çok tercih edilmelidir.

            //var msErr = numbers.Where(x => x < 8).Last(); //System.InvalidOperationException

            var msFoD = numbers.Where(x => x > 20).LastOrDefault(); //0 döner.

            List<string> names = new List<string>() { "Ali", "Trantod", "Markuziski" };

            var msS = names.Last(); //Markuziski

            var msSF = names.Where(name => name.Length < 8).Last(); //Trantod

            var msFoDS = names.Where(x => x.Length > 10).LastOrDefault(); //null

            //Mixed Syntax

            var mixedS = (from n in numbers
                          where n < 5
                          select n).LastOrDefault(); //4

            var mixedS1 = (from n in numbers
                          where n < -10
                          select n).LastOrDefault(); //0

            //var mixedS2 = (from n in numbers
            //              where n > 50
            //              select n).Last(); //System.InvalidOperationException

            Console.WriteLine();
        }
    }
}
*/
/*
namespace _15_ElementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>()
            {
                new User() { Id = 1, UserName = "Admin", Password = "Admin"},
                new User() { Id = 2, UserName = "User1", Password = "User1"},
                new User() { Id = 3, UserName = "User2", Password = "User2"},
                new User() { Id = 4, UserName = "User3", Password = "User3"}
            };

            var ms = users.Last(x => x.UserName == "Admin" && x.Password == "Admin");
            var msFD = users.LastOrDefault(x => x.UserName == "Admin" && x.Password == "Admin"); //1 Id'li objeyi dönerler.

            //var msF = users.Last(x => x.UserName == "Admin" && x.Password == "Admin123"); //Error

            var msFoD = users.LastOrDefault(x => x.UserName == "Admin" && x.Password == "Admin123"); //Null

            //Mixed Syntax

            var mixedS = (from user in users
                          select user).LastOrDefault(x => x.UserName == "Admin" && x.Password == "Admin"); //1 Id'li objeyi döner.

            var mixedS1 = (from user in users
                           select user).LastOrDefault(x => x.UserName == "User2" && x.Password == "User2"); //3 Id'li,

            var mixedS2 = (from user in users
                           select user).LastOrDefault(x => x.UserName == "User3" && x.Password == "User3"); //4 Id'li objeyi döner.

            Console.WriteLine();
        }
    }
}
class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
*/
#endregion

#region Single ve SingleOrDefault

using System.Globalization;

namespace _15_ElementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>() {  };
            //var ms = numbers.Single(); //System.InvalidOperationException: 'Sequence contains no elements'
            //var msSoD = numbers.SingleOrDefault(); //0 default değer.

            //List<int> numbers = new List<int>() {1};
            //var ms = numbers.Single(); //1
            //var msSoD = numbers.SingleOrDefault(); //1

            //List<int> numbers = new List<int>() { 1, 2 };
            //var ms = numbers.Single(); //System.InvalidOperationException: 'Sequence contains more than one element'
            //var msSoD = numbers.SingleOrDefault(); //System.InvalidOperationException: 'Sequence contains more than one element'

            List<int> numbers = new List<int>() { 1, 2 };
            var ms = numbers.Where(x => x > 1).Single(); //Şartı sağlayan 1 değer olduğu için hata vermez.
            //Ama ms'in içinde 2 olduğunu görürüz.
            //var ms1 = numbers.Where(x => x > 0).Single(); //System.InvalidOperationException: 'Sequence contains more than one element'
            //Hata verir. Çünkü artık şartı sağlayan 2 değer var. SingleOrDefault() olsaydı da farketmeyecekti.

            Console.WriteLine();
        }
    }
}

#endregion
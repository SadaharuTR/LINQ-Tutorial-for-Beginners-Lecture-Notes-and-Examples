﻿#region Take
/*
namespace _12_PartitioningDataOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 11, 2, 33, 42, 5, 64, 7, 8, 9, 10 };

            //Method Syntax
            var ms = numbers.Take(5).ToArray(); //Listeye dönüştürmek istersek ToList()
            //11,2,33,42,5

            //Mixed Syntax
            var mixedS = (from n in numbers select n).Take(5).ToList();
            //11,2,33,42,5

            Console.WriteLine();
        }
    }
}
*/
/*
namespace _12_PartitioningDataOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 11, 2, 33, 42, 5, 64, 7, 8, 9, 10 };

            //Method Syntax
            var ms = numbers.Where(x => x > 10).Take(5).ToArray(); 
            //11,33,42,64

            //Mixed Syntax
            var mixedS = (from n in numbers
                          where n > 10
                          select n).Take(5).ToList();
            //11,33,42,64

            //Peki Where'i Take'den sonra kullanırsak ne olur?
            var ms1 = numbers.Take(5).Where(x => x > 10).ToArray();
            //11,33,42
            //Önce ilk 5 kaydı alır sonra şarta uymayanları eler.
            Console.WriteLine();
        }
    }
}
*/
#endregion

#region TakeWhile
/*
namespace _12_PartitioningDataOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 33, 42, 5, 64, 7, 7, 8, 9, 100, 3, 4, 5 };

            //Method Syntax
            var ms = numbers.TakeWhile(x => x < 7).ToList();
            //1,2
            //33'ü gördüğü an sorgudan çıktı ve 1 ile 2'yi döndürdü. Geri kalan bazı değerler şartı sağlasa da bakmadı.
            var msW = numbers.Where(x => x % 2 == 0).TakeWhile(x => x < 50).ToList();
            //2,42
            var msW2 = numbers.TakeWhile(x => x < 50).Where(x => x % 2 == 0).ToList();
            //2,42

            //String'ler ile çalışalım,
            List<string> names = new List<string>() { "Ali", "Ferhat", "Şirin", "Faruk", "Ayşe", "Sevtap"};
            var ms1 = names.TakeWhile((name,index) => name.Length > index).ToList();
            //Ali,Ferhat,Şirin,Faruk çünkü Ayşe'nin harf sayısı ve index sayısı eşit. Şartı bozuyor. 
            var ms2 = names.TakeWhile(name => name.Length < 5).ToList();
            //Ali

            //Mixed Syntax
            var mixedS = (from n in numbers select n).TakeWhile(x => x < 7).ToList();
            //1,2
            var mixedS2 = (from str in names select str).TakeWhile((name, index) => name.Length > index).ToList();
            //Ali,Ferhat,Şirin,Faruk

            Console.WriteLine();
        }
    }
}
*/
#endregion

#region Skip
/*
namespace _12_PartitioningDataOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 33, 42, 5, 64, 7, 7, 8, 9, 100, 3, 4, 5 };

            var ms = numbers.Skip(3).ToList();
            //42, 5, 64, 7, 7, 8, 9, 100, 3, 4, 5

            var mixedS = (from n in numbers select n).Skip(5).ToList();
            //64, 7, 7, 8, 9, 100, 3, 4, 5

            //String'ler ile çalışalım,
            List<string> names = new List<string>() { "Ali", "Ferhat", "Şirin", "Faruk", "Ayşe", "Sevtap" };

            var msStr = names.Skip(3).ToList();
            //"Faruk", "Ayşe", "Sevtap"
            var mixedStr = (from n in names select n).Skip(3).ToList();
            //"Faruk", "Ayşe", "Sevtap"

            //Where ile kullanalım;

            var msW = numbers.Where(x => x > 10).Skip(2).ToList();
            //64,100
            var mixedStrW = (from n in names select n).Where(str => str.Length > 4).Skip(2).ToList();
            //Faruk,Sevtap

            //Where'i sonra kullanalım;
            var msW1 = numbers.Skip(2).Where(x => x > 10).ToList();
            //33,42,64,100
            var mixedStrW1 = (from n in names select n).Skip(2).Where(str => str.Length > 4).ToList();
            //Şirin,Faruk,Sevtap

            Console.WriteLine();
        }
    }
}
*/
#endregion

#region SkipWhile
/*
namespace _12_PartitioningDataOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 33, 42, 5, 64, 7, 7, 8, 9, 100, 3, 4, 5 };

            var ms = numbers.SkipWhile(num => num < 6).ToArray();
            //33, 42, 5, 64, 7, 7, 8, 9, 100, 3, 4, 5

            var mixedS = (from num in numbers select num).SkipWhile(num => num < 6).ToArray();
            //33, 42, 5, 64, 7, 7, 8, 9, 100, 3, 4, 5

            List<string> names = new List<string>() { "Ali", "Ferhat", "Şirin", "Faruk", "Ayşe", "Sevtap" };

            var ms1 = names.SkipWhile(x => x.Length < 4).ToList();
            //"Ferhat", "Şirin", "Faruk", "Ayşe", "Sevtap"

            var ms2 = names.SkipWhile((value, index) => value.Length < index).ToList();
            //"Ali", "Ferhat", "Şirin", "Faruk", "Ayşe", "Sevtap"

            Console.WriteLine();
        }
    }
}
*/
#endregion
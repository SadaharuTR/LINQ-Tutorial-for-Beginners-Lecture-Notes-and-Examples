namespace _13_PagingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPagePerView = 4; //bir sayfada gösterilecek toplam kayıt sayısı

            do
            {
                Console.WriteLine("Sayfa numarasını giriniz: ");
                if (int.TryParse(Console.ReadLine(), out int pageNumber))
                {
                    var ms = GetEmployees().Skip((pageNumber - 1) * totalPagePerView).Take(totalPagePerView);

                    foreach (var item in ms)
                    {
                        Console.WriteLine($"Id = {item.Id} and Name = {item.Name}");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Uygun bir sayfa numarası giriniz!.");
                } 
            } while (true);
        }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Sakata Gintoki"},
                new Employee() { Id = 2, Name = "Kotaro Katsura"},
                new Employee() { Id = 3, Name = "Shinsuke Takasugi"},
                new Employee() { Id = 4, Name = "Okita Sougo"},
                new Employee() { Id = 5, Name = "Kagura"},
                new Employee() { Id = 6, Name = "Shinpachi Shimura"},
                new Employee() { Id = 7, Name = "Kamui"},
                new Employee() { Id = 8, Name = "Tatsuma Sakamoto"},
                new Employee() { Id = 9, Name = "Kondo Isao"},
                new Employee() { Id = 10, Name = "Toshiro Hijikata"},
                new Employee() { Id = 11, Name = "Shoyo Yoshida"},
                new Employee() { Id = 12, Name = "Sarutobi Ayame"},
                new Employee() { Id = 13, Name = "Tae Shimura"},
                new Employee() { Id = 14, Name = "Sadaharu"},
                new Employee() { Id = 15, Name = "Sakata Kintoki"},
                new Employee() { Id = 16, Name = "Taizo Hasegawa"},
                new Employee() { Id = 17, Name = "Nizou Okeda"},
                new Employee() { Id = 18, Name = "Gengai Hiraga"},
                new Employee() { Id = 19, Name = "Anisaki Momo"},
                new Employee() { Id = 20, Name = "Terakado Ichi"}

            };
        }

    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
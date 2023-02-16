using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//yeni örnek için;
namespace _04_ProjectionOperators_SelectMany
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Techs> Programming { get; set; }
    }
}

/*
namespace _04_ProjectionOperators_SelectMany
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<string> Programming { get; set; }
    }
}
*/
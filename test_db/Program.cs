using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK.Repository;

namespace test_db
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=postgres;Timeout=300;CommandTimeout=300;";

            var a = new RepositoryOutputVK(s);

            var b = new RepositoryInputFileVK(null);

            var c = b.GetPersons("1.txt");

            a.CreateUser(c[0], "1.txt");


        }
    }
}

using EF010.CodeFirstMigration.Data;
using Microsoft.EntityFrameworkCore;

namespace EF010.CodeFirstMigration
{
    class Program
    {
        public static void Main(string[] args)
        {
            using(var _db = new AppDbContext())
            {
                

            }
    
            Console.ReadKey();
        }
    }
}


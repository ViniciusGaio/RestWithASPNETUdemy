using Microsoft.EntityFrameworkCore;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Data
{
    public class SeedingService
    {
        private readonly ModelBuilder _context;

        public SeedingService(ModelBuilder context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Entity<Person>().HasData(
                new { Id = 1, FirstName = "João", LastName = "Vitor", Address = "Curitiba - PR", Gender = "Male" },
                new { Id = 2, FirstName = "Leonardo", LastName = "Da Vinci", Address = "Anchiano - Italy", Gender = "Male" },
                new { Id = 3, FirstName = "Mahatma", LastName = "Gandhi", Address = "Porbandar - India", Gender = "Male" },
                new { Id = 4, FirstName = "Mohamed Ali", LastName = "Gandhi", Address = "Kentucky - USA", Gender = "Male" },
                new { Id = 5, FirstName = "Nelson", LastName = "Mandela", Address = "Mvezo - South Africa", Gender = "Male" },
                new { Id = 6, FirstName = "Vitoria", LastName = "Elizabeth", Address = "New England", Gender = "Female" },
                new { Id = 7, FirstName = "Ayrton", LastName = "Senna", Address = "São Paulo - Brasil", Gender = "Male" }
                );
     
            
            /*
            Person p1 = 
            Person p2 = new Person(2, "", "", "", "");
            Person p3 = new Person(3, "", "", "", "Male");
            Person p4 = new Person(4, "", "", "", "Male");
            Person p5 = new Person(5, "", "Gandhi", "", "Male");
            Person p6 = new Person(6, "", "", "", "Male");
            Person p7 = new Person(7, "", "", "", "Female");

            _context.People.AddRange(p1, p2, p3, p4, p5, p6, p7);

            _context.SaveChanges();
            */
        }

    }
}

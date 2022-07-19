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
            _context.Entity<Book>().HasData(
                new { Id = 1, Author = "Michael C. Feathers", Title = "Working effectively with legacy code", LaunchDate = new DateTime(2017,07,18), Price = 49.00 },
                new { Id = 2, Author = "Ralph Johnson, Erich Gamma, John Vlissides e Richard Helm", Title = "Design Patterns", LaunchDate = new DateTime(2017,11,29), Price = 45.00 },
                new { Id = 3, Author = "Robert C. Martin", Title = "Clean Code", LaunchDate = new DateTime(2009,01,10), Price = 56.00 },
                new { Id = 4, Author = "Crockford", Title = "JavaScript", LaunchDate = new DateTime(2017,11,07), Price = 67.00 },
                new { Id = 5, Author = "Steve McConnell", Title = "Code complete", LaunchDate = new DateTime(2017, 11, 07), Price = 58.00 },
                new { Id = 6, Author = "Martin Fowler e Kent Beck", Title = "Refactoring", LaunchDate = new DateTime(2017, 11, 07), Price = 88.00 },
                new { Id = 7, Author = "Eric Freeman, Elisabeth Freeman, Kathy Sierra, Bert Bates", Title = "Head First Design Patterns", LaunchDate = new DateTime(2017, 11, 07), Price = 110.00 },
                new { Id = 8, Author = "Eric Evans", Title = "Domain Driven Design", LaunchDate = new DateTime(2017, 11, 07), Price = 92.00 },
                new { Id = 9, Author = "Brian Goetz e Tim Peierls", Title = "Java Concurrency in Practice", LaunchDate = new DateTime(2017, 11, 07), Price = 80.00 },
                new { Id = 10, Author = "Susan Cain", Title = "O poder dos quietos", LaunchDate = new DateTime(2017, 11, 07, 15, 09, 01, 674), Price = 123.00 },
                new { Id = 11, Author = "Roger S. Pressman", Title = "Engenharia de Software: uma abordagem profissional", LaunchDate = new DateTime(2017, 11, 07), Price = 56.00 },
                new { Id = 12, Author = "Viktor Mayer-Schonberger e Kenneth Kukier", Title = "Big Data: como extrair volume, variedade, velocidade e valor da avalanche de informação cotidiana", LaunchDate = new DateTime(2017, 11, 07), Price = 54.00 },
                new { Id = 13, Author = "Richard Hunter e George Westerman", Title = "O verdadeiro valor de TI", LaunchDate = new DateTime(2017, 11, 07), Price = 95.00 },
                new { Id = 14, Author = "Marc J. Schiller", Title = "Os 11 segredos de líderes de TI altamente influentes", LaunchDate = new DateTime(2017, 11, 07), Price = 45.00 },
                new { Id = 15, Author = "Aguinaldo Aragon Fernandes e Vladimir Ferraz de Abreu", Title = "Implantando a governança de TI", LaunchDate = new DateTime(2017, 11, 07), Price = 54.00 });
        
     
            
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

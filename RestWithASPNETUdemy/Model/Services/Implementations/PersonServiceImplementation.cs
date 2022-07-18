﻿namespace RestWithASPNETUdemy.Model.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
           
        }

        public List<Person> FindAll()
        {
            List<Person> peoples = new List<Person>();
            for(int i=0; i < 8; i++)
            {
                Person person = Mockperson(i);
                peoples.Add(person);
            }
            return peoples;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Leandro",
                LastName = "Costa",
                Address = "Uberlandia -Minas Gerais - Brasil",
                Gender = "Male"

            };
        }

        public Person Update(Person person)
        {

            return person;
        }

        private Person Mockperson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Some Addres" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            
            return Interlocked.Increment(ref count);
        }
    }
}

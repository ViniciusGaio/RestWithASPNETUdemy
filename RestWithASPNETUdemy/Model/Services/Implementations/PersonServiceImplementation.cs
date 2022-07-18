using RestWithASPNETUdemy.Data;
using System;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;

namespace RestWithASPNETUdemy.Model.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private readonly ApplicationDbContext _context; 

        public PersonServiceImplementation(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Person> FindAll()
        {
            return _context.People.ToList();
        }

        public Person FindById(int id)
        {

            return _context.People.SingleOrDefault(p => p.Id.Equals(id));

        }


        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();

            }
            catch (Exception)
            { 
                throw;
            }
            return person;
        }
        public Person Update(Person person)
        {
            if (!Exists(person.Id)) throw new KeyNotFoundException("Person not found");

            var result = _context.People.SingleOrDefault(p => p.Id.Equals(person.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();

                }
                catch (Exception)
                {
                    throw;
                }
            }

            return person;
        }


        public void Delete(int id)
        {
            var result = _context.People.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.People.Remove(result);
                    _context.SaveChanges();

                }
                catch (Exception)
                {
                    throw;
                }
            }

        }

        private bool Exists(int id)
        {
            return _context.People.Any(p => p.Id.Equals(id));
        }
    }
}

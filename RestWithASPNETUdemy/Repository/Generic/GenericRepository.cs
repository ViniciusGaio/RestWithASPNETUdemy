using Microsoft.EntityFrameworkCore;
using RestWithASPNETUdemy.Data;
using RestWithASPNETUdemy.Model.Base;

namespace RestWithASPNETUdemy.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly ApplicationDbContext _context;

        private DbSet<T> dataset;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(int id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public T Update(T item)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;

                }
                catch (Exception)
                {
                    throw;
                }
            }
            else { return null; }

            
        }


        public void Delete(int id)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    dataset.Remove(result);
                    _context.SaveChanges();

                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
        public bool Exists(int id)
        {
            return dataset.Any(p => p.Id.Equals(id));
        }

    }
}

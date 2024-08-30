using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAL.Repositories
{

    //public class GenericRepository<T> where T : class
    //{
    //    protected readonly AppDbContext _context;

    //    public GenericRepository(AppDbContext context)
    //    {
    //        _context = context;
    //    }

    //    public IEnumerable<T> GetAll()
    //    {
    //        return _context.Set<T>().ToList();
    //    }

    //    public T GetById(int id)
    //    {
    //        return _context.Set<T>().Find(id);
    //    }

    //    public void Create(T entity)
    //    {
    //        _context.Set<T>().Add(entity);
    //        _context.SaveChanges();
    //    }

    //    public void Update(T entity)
    //    {
    //        _context.Entry(entity).State = EntityState.Modified;
    //        _context.SaveChanges();
    //    }

    //    public void Delete(int id)
    //    {
    //        var entity = _context.Set<T>().Find(id);
    //        if (entity != null)
    //        {
    //            _context.Set<T>().Remove(entity);
    //            _context.SaveChanges();
    //        }
    //    }
    //}
    public class GenericRepository<T> where T : class
    {
        protected readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}

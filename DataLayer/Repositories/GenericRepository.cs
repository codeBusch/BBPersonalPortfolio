using DataLayer.Abstratcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories;

public class GenericRepository<T> : IGeneric<T> where T : class
{
    private readonly ApplicationDbContext _context;
    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public void Add(T entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        _context.Remove(id);
        _context.SaveChanges();
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();

    }

    public T GetById(int id)
    {
        return _context.Find<T>(id);
    }

    public void Update(T entity)
    {
       _context.Update(entity);
        _context.SaveChanges();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Abstratcs
{
    public interface IGeneric<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}

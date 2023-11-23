using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly ProyectoFinalContext _context;
    public GenericRepository(ProyectoFinalContext context)
    {
        _context = context;
    }
    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void AddRange(IEnumerable<T> entities)
    {
        _context.Set<T>().AddRange(entities);
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression);

    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();

    }

    public virtual async Task<T> GetByIdAsync(string id)
    {
        return await _context.Set<T>().FindAsync();

    }

    public void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
}


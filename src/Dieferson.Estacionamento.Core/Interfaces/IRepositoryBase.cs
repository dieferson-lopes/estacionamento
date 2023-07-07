using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dieferson.Estacionamento.Core.Entities;

namespace Dieferson.Estacionamento.Core.Interfaces;

public interface IRepositoryBase<T> where T : BaseEntity
{
    IList<T> GetAllAsync();
    T GetByIdAsync(Guid id);
    T UpdateAsync(T entity);
    IList<T> AddAllAsync(List<T> entity);
    T AddAsync(T entity);
    void DeleteAsync(T entity);
    void DeleteByIdAsync(Guid id);
    void SaveChanges(T entity);
}
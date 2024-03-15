using AutomaticInversionofControl.API.Entities;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace AutomaticInversionofControl.API.Contracts.Repositories;

public interface IBaseRepository<TEntity> where TEntity : IEntity
{
    void Add(TEntity entity);
    void AddRangeAsync(List<TEntity> entities);
    void Delete(TEntity entity);
    IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> expression = null);
}

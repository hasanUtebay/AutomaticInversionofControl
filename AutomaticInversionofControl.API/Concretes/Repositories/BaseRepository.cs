using AutomaticInversionofControl.API.Contracts.Repositories;
using AutomaticInversionofControl.API.Entities;
using System.Linq.Expressions;

namespace AutomaticInversionofControl.API.Concretes.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IEntity
{
    private readonly List<TEntity> _list;
    public BaseRepository(List<TEntity> listOfEntity)
    {
        _list = listOfEntity;
    }

    public void Add(TEntity entity)
    {
         _list.Add(entity);
    }

    public void AddRangeAsync(List<TEntity> entities)
    {
          _list.AddRange(entities);
    }

    public void Delete(TEntity entity)
    {
        _list.Remove(entity);
    }
  public IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> expression = null)
    {
        if (expression != null) return _list.AsQueryable().Where(expression);

        return _list.AsQueryable();
    }
}

﻿
using Microsoft.EntityFrameworkCore;
using HotelProject.Entities.Abstract;


namespace HotelProject.DataAccess.Concretes.EntityFramework
{
    public class EfRepositoryBase<TEntity,TContext> : IRepository<TEntity> where TEntity : Entity<int>
        where TContext:DbContext
    {
        private readonly TContext _context;
        public EfRepositoryBase(TContext context)
        {
            _context = context;   
        }
        public TEntity Add(TEntity entity)
        {
           entity.CreatedTime = DateTime.Now;
           _context.Add(entity);
          // _context.SaveChanges();
           return entity;
        }

        public TEntity Delete(TEntity entity, bool IsDeleted = true)
        {
            if (IsDeleted)
            {
                _context.Remove(entity);
            }
           // _context.SaveChanges();
            return entity;

        }


        public TEntity? Get(Func<TEntity, bool> predicate)
        {
            return _context.Set<TEntity>().FirstOrDefault(predicate);
        }

        

        public IList<TEntity> GetList(Func<TEntity, bool>? predicate = null)
        {
            IEnumerable<TEntity> entities = _context.Set<TEntity>();
            return entities.ToList();
        }

        public TEntity Update(TEntity entity)
        {
            entity.UpdatedTime = DateTime.Now;
            _context.Update(entity);
        //    _context.SaveChanges();
            return entity;
        }
    }
}
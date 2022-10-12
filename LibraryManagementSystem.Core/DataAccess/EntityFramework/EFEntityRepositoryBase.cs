﻿using LibraryManagementSystem.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
      where TEntity : class, IEntity, new()
      where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {

                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
            return entity;
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {

                var deletedentity = context.Entry(entity);
                deletedentity.State = EntityState.Deleted;
                context.SaveChanges();

            }

        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())

            {

                return context.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
             
          

                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>()
                   .Where(filter).ToList();

            }

        }

        public TEntity Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {

                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
            return entity;
        }
    }
}

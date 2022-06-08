using BakanakE_Ticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BakanakE_Ticaret.Core.DataAccess.EntityFreamwork
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
    {
        public void Add(TEntity t)
        {
            using (var context = new TContext())
            {
                context.Add(t);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity t)
        {
            using (var context = new TContext())
            {
                context.Remove(t);
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
           using(var context = new TContext()) 
            {

                return context.Set<TEntity>().SingleOrDefault(filter); 
            
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity t)
        {
            using (var context = new TContext()) 
            {
                context.Update(t);
                context.SaveChanges();
            
            }
        }
    }
}

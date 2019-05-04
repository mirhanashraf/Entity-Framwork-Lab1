using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Smart.EF.Repository
{
    public class Repository<TEntity, TContext> : IRepository<TEntity>
        //lazm l TEntity yb2a mn noo3 Entity y3nii class mynfa3sh Interface
        where TEntity :class
        //lazm l TContext yb2a mn noo3 DbContext wlazm ykon 3ando default constructor 3shan a3raf ast5dm l constructor da w acreate mno object
        where TContext :DbContext , new()
    {
        TContext context;
        DbSet<TEntity> set;
        public Repository(TContext context)
        {
            this.context = context;
            set = context.Set<TEntity>();

        }
        public TEntity Add(TEntity entity)
        {
            set.Add(entity);
            return context.SaveChanges() > 0 ? entity : null;
        }

        public IQueryable<TEntity> GetAll()
        {
            //set de btrag3 7aga mn dbset l hya l entities mn no3ha l homa uni w l fac
            return set;
        }

        public TEntity GetById(params object[] id)
        {
            return set.Find(id);
        }

        public bool Remove(TEntity entity)
        {
            set.Remove(entity);
            return context.SaveChanges() > 0;
        }

        public bool Update(TEntity entity)
        {
            set.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0;
        }
    }
}

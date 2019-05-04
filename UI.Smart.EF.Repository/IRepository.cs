using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Smart.EF.Repository
{
    public interface IRepository<TEntity>
    {
        //baraga3 iQueryable 3shan lw rga3t list msh ha3rf a3ml .where wla l 7agat de
        IQueryable<TEntity> GetAll();
        TEntity GetById(params object[] id);
        TEntity Add(TEntity entity);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);

    }
}

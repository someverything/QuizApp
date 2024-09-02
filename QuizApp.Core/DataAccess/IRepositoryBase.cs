using QuizApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Core.DataAccess
{
    public interface IRepositoryBase<TEntity>
    where TEntity : class, IEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter, bool track = true);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null, bool track = true);
        void SaveEntity();
    }
}

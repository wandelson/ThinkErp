using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Think.Erp.Api.Domain.Entities;

namespace Think.Erp.Api.Domain.Repositories
{
    public interface IEntityRepository
    {
        Entity Get(int id);

              IEnumerable<Entity> GetAll();

        void Save(Entity entity);

        void Update(Entity entity);

        IEnumerable<Entity> GetByNickName(Expression<Func<Entity, bool>> predicate);

        void Delete(int id);

    }
}
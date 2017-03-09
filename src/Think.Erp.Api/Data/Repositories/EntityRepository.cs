using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Think.Erp.Api.Data.Contexts;
using Think.Erp.Api.Domain.Entities;
using Think.Erp.Api.Domain.Repositories;
using System.Linq;
using System.Linq.Expressions;

namespace Think.Erp.Api.Data.Repositories
{
    public class EntityRepository : IEntityRepository
    {
        private readonly DataContext _context;

        public EntityRepository(DataContext context)
        {
            _context = context;
        }

        public Entity Get(int id)
        {
            return _context.Entities.Find(id);
        }

         public IEnumerable<Entity> GetAll()
        {
            return _context.Entities.AsNoTracking();
        }


        public void Save(Entity entity)
        {
            _context.Entities.Add(entity);
        }

        public void Update(Entity entity)
        {
            _context.Entities.Update(entity);
        }

        public void Delete(int id)
        {
            _context.Entities.Remove(Get(id));
        }


        public IEnumerable<Entity> GetByNickName(Expression<Func<Entity, bool>> predicate)
        {
            return _context.Entities.AsNoTracking().Where(predicate);
        }

    }
}
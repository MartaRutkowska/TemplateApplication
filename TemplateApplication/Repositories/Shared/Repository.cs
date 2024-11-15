﻿using Microsoft.EntityFrameworkCore;

namespace TemplateApplication.Repositories.Shared
{
    public class Repository<TEntity>(DbContext context) : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context = context;

        public async Task Add(TEntity entity) => await Context.Set<TEntity>().AddAsync(entity);

        public async Task AddRange(IEnumerable<TEntity> entities) => await Context.Set<TEntity>().AddRangeAsync(entities);

        public async Task<TEntity?> Get(int id) => await Context.Set<TEntity>().FindAsync(id);

        public async Task<IEnumerable<TEntity>> GetAll() => await Context.Set<TEntity>().ToListAsync();

        public void Remove(TEntity entity) => Context.Set<TEntity>().Remove(entity);

        public void RemoveRange(IEnumerable<TEntity> entities) => Context.Set<TEntity>().RemoveRange(entities);
    }
}

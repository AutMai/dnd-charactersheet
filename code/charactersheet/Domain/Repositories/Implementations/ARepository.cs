using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Domain.Extensions;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Configurations;

namespace Domain.Repositories.Implementations;

public class ARepository<TEntity> : IRepository<TEntity> where TEntity : class {
    protected IDbContextFactory<CharacterSheetDbContext> _contextFactory;

    public ARepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) {
        _contextFactory = contextFactory;
    }

    public async Task<TEntity?> ReadAsync(int id) {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<TEntity>();
        return await set.FindAsync(id);
    }

    public async Task<List<TEntity>> ReadAsync(Expression<Func<TEntity, bool>> filter) {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<TEntity>();
        return await set.Where(filter).ToListAsync();
    }

    public async Task<List<TEntity>> ReadAsync() {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<TEntity>();
        return await set.ToListAsync();
    }


    public async Task<List<TEntity>> ReadAsync(int start, int count) {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<TEntity>();
        return await set.Skip(start).Take(count).ToListAsync();
    }

    public async Task<TEntity> CreateAsync(TEntity entity) {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<TEntity>();
        set.Add(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(TEntity entity) {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<TEntity>();
        //_context.ChangeTracker.Clear();
        set.Update(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(TEntity entity) {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<TEntity>();
        set.Remove(entity);
        await context.SaveChangesAsync();
    }

    public async Task<TEntity?> ReadWithAllIncludes(int id) {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<TEntity>();
        var e = await set.FindAsync(id);
        return await set.IncludeAll().SingleOrDefaultAsync(k => Equals(k, e));
    }
}
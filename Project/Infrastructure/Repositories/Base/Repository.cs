using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Repositories.Base;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Base;

public class Repository<T> : IRepository<T>
    where T : class, new()
{
    protected readonly AppDbContext DbContext;

    public Repository(AppDbContext dbContext)
    {
        this.DbContext = dbContext;
    }

    public IQueryable<T> GetQuery(Expression<Func<T, bool>> expression) => this.DbContext.Set<T>().Where(expression);

    public T Add(T itemToAdd)
    {
        var entity = this.DbContext.Add(itemToAdd);
        this.DbContext.SaveChanges();
        return entity.Entity;
    }

    public async Task<T> AddAsync(T itemToAdd)
    {
        var entity = await this.DbContext.AddAsync(itemToAdd);
        await this.DbContext.SaveChangesAsync();
        return entity.Entity;
    }

    public T GetById(Guid id) =>
        this.DbContext.Set<T>()
            .Find(id);

    public async Task<T> GetByIdAsync(Guid id) =>
        await this.DbContext.Set<T>()
            .FindAsync(id);

    public T GetById(int id) =>
        this.DbContext.Set<T>()
            .Find(id);

    public async Task<T> GetByIdAsync(int id) =>
        await this.DbContext.Set<T>()
            .FindAsync(id);

    public T GetById(string id) =>
        this.DbContext.Set<T>()
            .Find(id);

    public async Task<T> GetByIdAsync(string id) =>
        await this.DbContext.Set<T>()
            .FindAsync(id);

    public bool Delete(T itemToDelete)
    {
        this.DbContext.Remove(itemToDelete);
        this.DbContext.SaveChanges();
        return true;
    }

    public async Task<bool> DeleteAsync(T itemToDelete)
    {
        this.DbContext.Remove(itemToDelete);
        await this.DbContext.SaveChangesAsync();
        return true;
    }

    public IEnumerable<T> GetAll() =>
        this.DbContext.Set<T>()
            .AsEnumerable();

    public int GetCount() => this.DbContext.Set<T>().Count();

    public T Update(T itemToUpdate)
    {
        var entity = this.DbContext.Update(itemToUpdate);
        this.DbContext.SaveChangesAsync();
        return entity.Entity;
    }

    public async Task<T> UpdateAsync(T itemToUpdate)
    {
        this.DbContext.ChangeTracker.Clear();
        var entity = this.DbContext.Update(itemToUpdate);
        await this.DbContext.SaveChangesAsync();
        return entity.Entity;
    }

    public IQueryable<T> Query(bool eager = false)
    {
        var query = this.DbContext.Set<T>().AsQueryable();
        if (!eager)
            return query;

        var navigations = this.DbContext.Model.FindEntityType(typeof(T))?
            .GetDerivedTypesInclusive()
            .SelectMany(type => type.GetNavigations())
            .Distinct();

        foreach (var property in navigations)
            query = query.Include(property.Name);

        return query;
    }

    //public async Task<int> UpdateAsyncWithAllChildren(T entity)
    //{
    //    var navigations = this.DbContext.Model.FindEntityType(typeof(T))?
    //        .GetDerivedTypesInclusive()
    //        .SelectMany(type => type.GetNavigations())
    //        .Distinct();

    //    var dbEntity = await this.DbContext.FindAsync<T>(entity.Id);

    //    if (dbEntity == null)
    //        return 0;

    //    var dbEntry = this.DbContext.Entry(dbEntity);
    //    dbEntry.CurrentValues.SetValues(entity);

    //    foreach (var property in navigations)
    //    {
    //        var propertyName = property.Name;
    //        var dbItemsEntry = dbEntry.Collection(propertyName);
    //        var accessor = dbItemsEntry.Metadata.GetCollectionAccessor();

    //        await dbItemsEntry.LoadAsync();
    //        if (dbItemsEntry.CurrentValue is null)
    //            continue;

    //        var dbItemsMap = ((IEnumerable<BaseEntity>)dbItemsEntry.CurrentValue)
    //            .ToDictionary(e => e.Id);

    //        if (accessor is not null)
    //        {
    //            var items = (IEnumerable<BaseEntity>)accessor.GetOrCreate(entity, true);

    //            foreach (var item in items)
    //            {
    //                if (!dbItemsMap.TryGetValue(item.Id, out var oldItem))
    //                {
    //                    accessor.Add(dbEntity, item, true);
    //                }
    //                else
    //                {
    //                    this.DbContext.Entry(oldItem).CurrentValues.SetValues(item);
    //                    dbItemsMap.Remove(item.Id);
    //                }
    //            }
    //        }

    //        foreach (var oldItem in dbItemsMap.Values)
    //            accessor?.Remove(dbEntity, oldItem);
    //    }

    //    return await this.DbContext.SaveChangesAsync();
    //}

    //public async Task<int> UpdateAsyncWithChildren(T entity, params Expression<Func<T, object>>[] navigations)
    //{
    //    var dbEntity = await this.DbContext.FindAsync<T>(entity.Id);

    //    if (dbEntity == null)
    //        return 0;

    //    var dbEntry = this.DbContext.Entry(dbEntity);
    //    dbEntry.CurrentValues.SetValues(entity);

    //    foreach (var property in navigations)
    //    {
    //        var propertyName = property.GetPropertyAccess().Name;
    //        var dbItemsEntry = dbEntry.Collection(propertyName);
    //        var accessor = dbItemsEntry.Metadata.GetCollectionAccessor();

    //        await dbItemsEntry.LoadAsync();
    //        if (dbItemsEntry.CurrentValue is null)
    //            continue;

    //        var dbItemsMap = ((IEnumerable<BaseEntity>)dbItemsEntry.CurrentValue)
    //            .ToDictionary(e => e.Id);

    //        if (accessor is not null)
    //        {
    //            var items = (IEnumerable<BaseEntity>)accessor.GetOrCreate(entity, true);

    //            foreach (var item in items)
    //            {
    //                if (!dbItemsMap.TryGetValue(item.Id, out var oldItem))
    //                {
    //                    accessor.Add(dbEntity, item, true);
    //                }
    //                else
    //                {
    //                    this.DbContext.Entry(oldItem).CurrentValues.SetValues(item);
    //                    dbItemsMap.Remove(item.Id);
    //                }
    //            }
    //        }

    //        foreach (var oldItem in dbItemsMap.Values)
    //            accessor?.Remove(dbEntity, oldItem);
    //    }

    //    return await this.DbContext.SaveChangesAsync();
    //}

    public void Save() => this.DbContext.SaveChanges();

    public async Task SaveAsync() => await this.DbContext.SaveChangesAsync();

    public async Task<List<T>> GetAllAsync() =>
        await this.DbContext.Set<T>()
            .ToListAsync();

    public IQueryable<T> GetTable() => this.DbContext.Set<T>();
}
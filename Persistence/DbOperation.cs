﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;


namespace Persistence
{

    public class DbOperation<TEntity> : IDisposable, Core.IRepo<TEntity> where TEntity : class
    {
        private readonly SchoolDbContext _db;
        internal DbSet<TEntity> DbSet;

        public DbOperation(SchoolDbContext context)
        {
            _db = context;
            DbSet = context.Set<TEntity>();

        }

        public virtual IEnumerable<TEntity> Find(
          Expression<Func<TEntity, bool>> filter = null,
          Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
          string includeProperties = "")
        {
            IQueryable<TEntity> query = DbSet;

            if (filter != null)
                query = query.Where(filter);

            query = includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(includeProperty => includeProperty.Trim())
                .Aggregate(query, (current, includeString) => current.Include(includeString));

            if (orderBy != null)
                query = orderBy(query);

            return query.ToList();
        }

        public TEntity Get(int id) => DbSet.Find(id);

        public async Task<TEntity> GetAsync(int id) => await DbSet.FindAsync(id);

        public TEntity Get(Expression<Func<TEntity, bool>> predicate, bool withDeleted = false) => DbSet.Where(predicate).FirstOrDefault();

        public async Task<TEntity> GetAsyncById(int id, params string[] include)
        {
            var item = await DbSet.FindAsync(id);
            if (item == null) return null;
            foreach (var express in include)
                _db.Entry(item).Reference(express).Load();
            return item;
        }
        public List<TEntity> GetQueryAsync(string sql)
        {
            var item = DbSet.FromSql(sql).ToList();
            return item;
        }

        public Task<List<TEntity>> GetAsyncAsNoTracking(Expression<Func<TEntity, bool>> predicate, params string[] include)
        {
            IQueryable<TEntity> list = DbSet.AsNoTracking().Where(predicate);

            list = include.Aggregate(list, (current, item) => current.Include(item));

            foreach (TEntity entity in list.ToList())
                _db.Entry(entity).State = EntityState.Detached;

            return list.ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params string[] include)
        {
            TEntity list = await DbSet.Where(predicate).FirstOrDefaultAsync();

            foreach (string expres in include)
                _db.Entry(list).Reference(expres).Load();

            return list;
        }

        public List<TEntity> GetAll<TProperty>(params Expression<Func<TEntity, TProperty>>[] include)
        {
            IQueryable<TEntity> list = DbSet.AsQueryable();
            list = include.Aggregate(list, (current, item) => current.Include(item));
            return list.ToList();
        }


        public List<TEntity> GetAllWhere(Expression<Func<TEntity, bool>> predicate, params string[] include)
        {
            IQueryable<TEntity> list = DbSet.Where(predicate);
            list = include.Aggregate(list, (current, item) => current.Include(item));
            return list.ToList();
        }

        public async Task<List<TEntity>> GetAllAsync(params string[] include)
        {
            IQueryable<TEntity> list = DbSet.AsQueryable();
            list = include.Aggregate(list, (current, item) => current.Include(item));
            return await list.ToListAsync();
        }

        public Task<List<TEntity>> GetAllSyncNew(Expression<Func<TEntity, bool>> predicate, bool withDeleted = false) => DbSet.Where(predicate).ToListAsync();

        public Task<List<TEntity>> GetAllWhereAsync(Expression<Func<TEntity, bool>> predicate) => DbSet.Where(predicate).ToListAsync();

        public Task<List<TEntity>> GetAllWhereAsync(Expression<Func<TEntity, bool>> predicate, params string[] include)
        {
            IQueryable<TEntity> list = DbSet.Where(predicate);

            list = include.Aggregate(list, (current, item) => current.Include(item));

            return list.ToListAsync();
        }

        //public async Task<PageViewModel<TEntity>> GetPage(
        //    int pageIndex,
        //    int pageSize,
        //    Expression<Func<TEntity, bool>> filter = null,
        //    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        //    string includeProperties = ""
        //)
        //{
        //    IQueryable<TEntity> query = DbSet;

        //    if (filter != null)
        //        query = query.Where(filter);

        //    foreach (string includeProperty in includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //        query = query.Include(includeProperty);

        //    if (orderBy != null)
        //        query = orderBy(query);

        //    return new PageViewModel<TEntity>
        //    {
        //        PageIndex = pageIndex,
        //        PageSize = pageSize,
        //        Data = await query.ToListAsync(),
        //        Length = query.Count()
        //    };
        //}

        public int Count(Expression<Func<TEntity, bool>> predicate) => DbSet.Count(predicate);

        public Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate) => DbSet.CountAsync(predicate);

        public int Min(Expression<Func<TEntity, int>> predicate, Expression<Func<TEntity, bool>> condition) => DbSet.Where(condition).Min(predicate);

        public Task<int> MinAsync(Expression<Func<TEntity, int>> predicate, Expression<Func<TEntity, bool>> condition) => DbSet.Where(condition).MinAsync(predicate);

        public int Max(Expression<Func<TEntity, int>> predicate, Expression<Func<TEntity, bool>> condition) => DbSet.Where(condition).Max(predicate);

        public Task<TResult> MaxAsync<TResult>(Expression<Func<TEntity, TResult>> predicate) => DbSet.MaxAsync(predicate);

        public TResult MaxWhere<TResult>(Expression<Func<TEntity, TResult>> predicate, Expression<Func<TEntity, bool>> condition)
        {
            IQueryable<TEntity> query = DbSet.Where(condition);

            if (!query.Any())
                return (TResult)Activator.CreateInstance(typeof(TResult));

            TResult entity = query.Max(predicate);

            return entity;
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate) => DbSet.Any(predicate);

        public double Sum(Expression<Func<TEntity, double>> predicate, Expression<Func<TEntity, bool>> condition, params string[] include)
        {
            IQueryable<TEntity> list = DbSet.Where(condition);
            list = include.Aggregate(list, (current, item) => current.Include(item));
            return list.Sum(predicate);
        }

        public Task<double> SumAsync(Expression<Func<TEntity, double>> predicate, Expression<Func<TEntity, bool>> condition, params string[] include)
        {
            IQueryable<TEntity> list = DbSet.Where(condition).AsQueryable();
            list = include.Aggregate(list, (current, item) => current.Include(item));
            return list.SumAsync(predicate);
        }

        public TEntity Add(TEntity obj)
        {
            DbSet.Add(obj);
          //  _db.SaveChanges();
            return obj;
        }

        public async Task<TEntity> AddAsync(TEntity obj)
        {
            await DbSet.AddAsync(obj);
           //  _db.SaveChanges();
             return obj;
        }

        public async Task<IList<TEntity>> AddRangeAsync(IList<TEntity> obj)
        {
            await DbSet.AddRangeAsync(obj);
            return obj;
        }

        public IList<TEntity> AddRange(IList<TEntity> obj)
        {
            DbSet.AddRange(obj);
            return obj;
        }

        public TEntity Update(TEntity obj)
        {
            var isDetached = _db.Entry(obj).State == EntityState.Detached;
            if (isDetached)
                DbSet.Attach(obj);
            DbSet.Update(obj);
            return obj;
        }



        public IList<TEntity> UpdateRange(IList<TEntity> obj)
        {
            DbSet.UpdateRange(obj);
            return obj;
        }

        public TEntity Update(int id, TEntity obj)
        {
            DbSet.Update(obj);
            return obj;
        }

        public Task Delete(TEntity obj)
        {
            if (obj != null)
            {
                DbSet.Remove(obj);
            }
            return Task.CompletedTask;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _db.Set<TEntity>().Remove(entity);
            //await _db.SaveChanges();
        }

        public void SaveChanges() => _db.SaveChanges();

        public Task Delete(Expression<Func<TEntity, bool>> predicate)
        {
            List<TEntity> objLst = DbSet.Where(predicate).ToList();
            return DeleteAll(objLst);
        }

        public Task DeleteAll(List<TEntity> obj)
        {
            DbSet.RemoveRange(obj);
            return Task.CompletedTask;
        }

        public Task Delete(object id)
        {
           
            var obj = DbSet.Find(id);
            return Delete(obj);
        }

       

        public void Dispose() => _db.Dispose();
        public Task DeleteAll(IEnumerable<int> obj)
        {
            foreach (var selected in obj)
                Delete(selected);
            return Task.CompletedTask;
        }
    }

    public static class ObjectExtensions
    {
        public static void CopyFrom<TTo, TFrom>(this TTo target, TFrom source) where TTo : class
        {
            Type myType = target.GetType();
            var list = myType.GetProperties()
                .Where(c => c.PropertyType.Assembly.GetName().Name == "mscorlib"
                            && (!c.PropertyType.IsGenericType ||
                                Nullable.GetUnderlyingType(c.PropertyType) != null)).ToList();
            foreach (var prop in list)
            {
                object propValue = prop.GetValue(source, null);
                prop.SetValue(target, propValue);
            }
        }
    }
}

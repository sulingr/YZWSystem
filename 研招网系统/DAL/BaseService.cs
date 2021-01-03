using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using 研招网系统.Models;

namespace 研招网系统.DAL
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity,new()
    {
        private readonly YZWModels _db;

        public BaseService(YZWModels db)
        {
            _db = db;
        }
        public async Task CreateAsync(T model, bool saved = true)
        {
            _db.Set<T>().Add(model);
            if (saved) await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task EditAsync(T model, bool saved = true)
        {
            _db.Configuration.ValidateOnSaveEnabled = false;
            _db.Entry(model).State = EntityState.Modified;
            if (saved)
            {
                await _db.SaveChangesAsync();
                _db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        public IQueryable<T> GetAll()
        {
            return _db.Set<T>().AsNoTracking();
        }

        public IQueryable<T> GetAllByPage(int pageSize = 10, int pageIndex = 0)
        {
            return GetAll().Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<T> GetAllByPageOrder(int pageSize = 10, int pageIndex = 0, bool asc = true)
        {
            return GetAllOrder(asc).Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<T> GetAllOrder(bool asc = true)
        {
            var datas = GetAll();
            datas = asc ? datas.OrderBy(m => m.Id) : datas.OrderByDescending(m => m.Id);
            return datas;
        }

        public async Task<T> GetoneById(Guid id)
        {
            return await GetAll().FirstAsync(m => m.Id == id);
        }

        public async Task RemoveAsync(Guid id, bool saved = true)
        {
            _db.Configuration.ValidateOnSaveEnabled = false;
            var t = new T() { Id = id };
            _db.Entry(t).State = EntityState.Deleted;
            if (saved)
            {
                await _db.SaveChangesAsync();
                _db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        public async Task RemoveAsync(T model, bool saved = true)
        {
            await RemoveAsync(model.Id,saved);
        }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
            _db.Configuration.ValidateOnSaveEnabled = true;
        }
    }
}
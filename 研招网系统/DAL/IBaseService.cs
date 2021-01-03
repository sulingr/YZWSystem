using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using 研招网系统.Models;

namespace 研招网系统.DAL
{
    public interface IBaseService<T>:IDisposable where T:BaseEntity
    {
        Task CreateAsync(T model,bool saved=true);
        Task EditAsync(T model,bool saved=true);
        Task RemoveAsync(Guid id,bool saved=true);
        Task RemoveAsync(T model,bool saved=true);
        Task Save();
        Task<T> GetoneById(Guid id);
        IQueryable<T> GetAll();
        IQueryable<T> GetAllByPage(int pageSize = 10, int pageIndex = 0);
        IQueryable<T> GetAllOrder(bool asc = true);
        IQueryable<T> GetAllByPageOrder(int pageSize = 10, int pageIndex = 0, bool asc = true);
    }
}
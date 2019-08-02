using Project.BLL.InterfaceRepository;
using Project.BLL.SingletonPattern;
using Project.DAL.Context;
using Project.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.BaseRepository
{
  public  class BaseRepository<T>:IRepository<T> where T : BaseEntity
    {
        protected MyContext db;
        public BaseRepository()
        {
            db = DBTool.DBInstance;
        }

        public void Add(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public T Default(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().FirstOrDefault(exp);
        }

        public void Delete(T item)
        {
            item.Status = MODEL.Enum.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            db.SaveChanges();
        }

        public T GetByID(int id)
        {
            return db.Set<T>().Find(id);
        }

        public object ListAnonymus(Expression<Func<T, object>> exp)
        {
            return db.Set<T>().Select(exp);
        }

        public List<T> SelectActives()
        {
            return db.Set<T>().Where(x => x.Status != MODEL.Enum.DataStatus.Deleted).ToList();
        }

        public List<T> SelectAll()
        {
            return db.Set<T>().ToList();
        }

        public List<T> SelectDeleteds()
        {
            return db.Set<T>().Where(x => x.Status == MODEL.Enum.DataStatus.Deleted).ToList();
        }

        public List<T> SelectModifieds()
        {
            return db.Set<T>().Where(x => x.Status == MODEL.Enum.DataStatus.Updated).ToList();
        }

        public void SpeacialDelete(int id)
        {
            db.Set<T>().Remove(GetByID(id));
        }

        public void Update(T item)
        {
            item.Status = MODEL.Enum.DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            T toBeUpdated = GetByID(item.ID);
            db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            db.SaveChanges();

        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).ToList();
        }
    }
}

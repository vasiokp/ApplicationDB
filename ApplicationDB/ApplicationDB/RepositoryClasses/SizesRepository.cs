using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationDB
{
    class SizesRepository:IRepository<Size>
    {
        private PizzaDBEntities db;

        public SizesRepository(PizzaDBEntities context)
        {
            this.db = context;
        }

        public IEnumerable<Size> GetList()
        {
            return db.Sizes;
        }

        public Size GetById(int id)
        {
            return db.Sizes.Find(id);
        }

        public void Create(Size size)
        {
            db.Sizes.Add(size);
        }

        public void Update(Size size)
        {
            db.Entry(size).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Size size = db.Sizes.Find(id);
            if (size != null)
                db.Sizes.Remove(size);
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

       public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            disposed = true;
        }
    }
}

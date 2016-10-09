using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationDB
{
    class DeliverysRepository : IRepository<Delivery>
    {
        private PizzaDBEntities db;

        public DeliverysRepository(PizzaDBEntities context)
        {
            this.db = context;
        }

        public IEnumerable<Delivery> GetList()
        {
            return db.Deliverys;
        }

        public Delivery GetById(int id)
        {
            return db.Deliverys.Find(id);
        }

        public void Create(Delivery delivery)
        {
            db.Deliverys.Add(delivery);
        }

        public void Update(Delivery delivery)
        {
            db.Entry(delivery).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Delivery delivery = db.Deliverys.Find(id);
            if (delivery != null)
                db.Deliverys.Remove(delivery);
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

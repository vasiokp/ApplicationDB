using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationDB
{
    class OrdersStatusRepository : IRepository<OrdersStatu>
    {
        private PizzaDBEntities db;

        public OrdersStatusRepository(PizzaDBEntities context)
        {
            this.db = context;
        }

        public IEnumerable<OrdersStatu> GetList()
        {
            return db.OrdersStatus;
        }

        public OrdersStatu GetById(int id)
        {
            return db.OrdersStatus.Find(id);
        }

        public void Create(OrdersStatu orderstate)
        {
            db.OrdersStatus.Add(orderstate);
        }

        public void Update(OrdersStatu orderstate)
        {
            db.Entry(orderstate).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            OrdersStatu orderstate = db.OrdersStatus.Find(id);
            if (orderstate != null)
                db.OrdersStatus.Remove(orderstate);
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

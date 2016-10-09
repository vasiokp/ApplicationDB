using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationDB
{
    class PizzasRepository : IRepository<Pizza>
    {
        private PizzaDBEntities db;

        public PizzasRepository(PizzaDBEntities context)
        {
            this.db = context;
        }

        public IEnumerable<Pizza> GetList()
        {
            return db.Pizzas;
        }

        public Pizza GetById(int id)
        {
            return db.Pizzas.Find(id);
        }

        public void Create(Pizza pizza)
        {
            db.Pizzas.Add(pizza);
        }

        public void Update(Pizza pizza)
        {
            db.Entry(pizza).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Pizza pizza = db.Pizzas.Find(id);
            if (pizza != null)
                db.Pizzas.Remove(pizza);
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

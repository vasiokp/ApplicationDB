using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDB
{
    class UnitofWork:IDisposable
    {
        private PizzaDBEntities db = new PizzaDBEntities();
        

        private DeliverysRepository deliverysRepository;
        private OrdersRepository ordersRepository;
        private OrdersStatusRepository orderstatusRepository;
        private PizzasRepository pizzasRepository;
        private RolesRepository rolesRepository;
        private SizesRepository sizesRepository;
        private UsersRepository usersRepository;
        
      

        public UsersRepository Users
        {
            get
            {
                if (usersRepository == null)
                    usersRepository = new UsersRepository(db);
                return usersRepository;

            }
        }

        public SizesRepository Sizes
        {
            get
            {
                if (sizesRepository == null)
                    sizesRepository = new SizesRepository(db);
                return sizesRepository;
            }
        }

        public RolesRepository Roles
        {
            get
            {
                if (rolesRepository == null)
                    rolesRepository = new RolesRepository(db);
                return rolesRepository;
            }
        }

        public DeliverysRepository Deliverys
        {
            get
            {
                if (deliverysRepository == null)
                    deliverysRepository = new DeliverysRepository(db);
                return deliverysRepository;
            }
        }

        public OrdersRepository Orders
        {
            get
            {
                if (ordersRepository == null)
                    ordersRepository = new OrdersRepository(db);
                return ordersRepository;
            }
        }

        public OrdersStatusRepository OrdersStatus
        {
            get
            {
                if (orderstatusRepository == null)
                    orderstatusRepository = new OrdersStatusRepository(db);
                return orderstatusRepository;
            }
        }

        public PizzasRepository Pizzas
        {
            get
            {
                if (pizzasRepository == null)
                    pizzasRepository = new PizzasRepository(db);
                return pizzasRepository;
            }
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Save()
        {
            db.SaveChanges();
        }

    }
}

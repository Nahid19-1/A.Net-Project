using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class CartRepo : IRepository<Cart, int>
    {
        private CircularBusEntities db;

        public CartRepo(CircularBusEntities db)
        {
            this.db = db;
        }
        public Cart Add(Cart obj)
        {
            throw new NotImplementedException();
        }

        public Cart Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Cart Edit(Cart obj)
        {
            throw new NotImplementedException();
        }

        public Cart Get(int id)
        {
            //Sum(s =>s.BS_Fair)
            var data = (from c in db.Carts
                        where c.B_Id==id 
                        select c).FirstOrDefault();

            return data;
        }

        public List<Cart> Get()
        {
            return db.Carts.ToList();
        }

        public List<Cart> Buslist(int id)
        {
            var data = (from c in db.Carts
                        where c.B_Id == id
                        select c).ToList();


            return data;
        }


    }
}

using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class BusOwnerRepo : IRepository<User, int>
    {
        private CircularBusEntities db;

        public BusOwnerRepo(CircularBusEntities db)
        {
            this.db = db;
        }


        public User Add(User obj)
        {
            db.Users.Add(obj);
            db.SaveChanges();
            return db.Users.FirstOrDefault();
        }

        public User AddtoCart(User obj)
        {
            throw new NotImplementedException();
        }

        public List<User> Buslist(int id)
        {
            throw new NotImplementedException();
            //return db.BusInfoes.Where(dn => dn.B_OwnedBy == id).ToList();
        }

        public User Delete(int id)
        {
            var e = db.Users.FirstOrDefault(dn => dn.U_Id == id);
            db.Users.Remove(e);
            db.SaveChanges();
            return db.Users.FirstOrDefault();
        }

        public User Edit(User u)
        {
            var p = db.Users.FirstOrDefault(dn => dn.U_Id == u.U_Id);
            db.Entry(p).CurrentValues.SetValues(u);
            db.SaveChanges();
            return db.Users.FirstOrDefault();
        }

        public User Get(int id)
        {
            return db.Users.FirstOrDefault(x => x.U_Id == id);
        }

        public List<User> Get()
        {
            return db.Users.Where(dn => dn.U_Role == "BusOwner  ").ToList();
        }

        public List<User> Purchase(int id)
        {
            throw new NotImplementedException();
        }
    }
}

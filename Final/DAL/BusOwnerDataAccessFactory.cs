using DAL.Database;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BusOwnerDataAccessFactory
    {
        static CircularBusEntities db = new CircularBusEntities();
        public static IRepository<User, int> BusOwnerDataAccess()
        {
            return new BusOwnerRepo(db);
        }
        public static IRepository<BusInfo, int> BusDataAccess()
        {
            return new BusRepo(db);
        }
        public static IRepository<BusRoute, int> BusRouteDataAccess()
        {
            return new BusRouteRepo(db);
        }
    }
}

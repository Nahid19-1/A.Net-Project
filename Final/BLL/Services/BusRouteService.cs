using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;

namespace BLL.Services
{
    public class BusRouteService
    {
        public static List<BusRouteModel> Get()
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusRoute, BusRouteModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BusRouteModel>>(BusOwnerDataAccessFactory.BusRouteDataAccess().Get());
            return data;
        }
        public static BusRouteModel Get(int id)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusRoute, BusRouteModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BusRouteModel>(BusOwnerDataAccessFactory.BusRouteDataAccess().Get(id));
            return data;
        }
        public static BusRouteModel GetBusList(int id)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusRoute, BusRouteModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BusRouteModel>(BusOwnerDataAccessFactory.BusRouteDataAccess().Buslist(id));
            return data;
        }
        public static void Add(BusRouteModel obj)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusRouteModel, BusRoute>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BusRoute>(obj);
            BusOwnerDataAccessFactory.BusRouteDataAccess().Add(data);
        }
        public static void Edit(BusRouteModel obj)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusRouteModel, BusRoute>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BusRoute>(obj);
            BusOwnerDataAccessFactory.BusRouteDataAccess().Edit(data);
        }
        public static void Delete(int i)
        {

            BusOwnerDataAccessFactory.BusRouteDataAccess().Delete(i);
        }

        //NAHID
        public static List<BusRouteModel> BRouts()
        {
            var sts = UserDataAccessFectory.BusRouteDataAccess().Get();
            List<BusRouteModel> data = new List<BusRouteModel>();
            foreach (var s in sts)
            {
                data.Add(new BusRouteModel()
                {
                    BR_Id = s.BR_Id,
                    BR_Start = s.BR_Start,
                    BR_End = s.BR_End,
                    BR_Stopage1 = s.BR_Stopage1,
                    BR_Stopage2 = s.BR_Stopage2,
                    BR_Stopage3 = s.BR_Stopage3,
                    BR_Time = s.BR_Time,
                    BR_FairInS1 = s.BR_FairInS1,
                    BR_FairInS2 = s.BR_FairInS2,
                    BR_FairInS3 = s.BR_FairInS3

                });

            }
            return data;
        }
        //NAHID
    }
}

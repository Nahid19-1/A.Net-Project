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
    public class BusOwnerService
    {
        public static List<BusOwnerModel> Get()
        {
            var config = new MapperConfiguration(c => c.CreateMap<User, BusOwnerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BusOwnerModel>>(BusOwnerDataAccessFactory.BusOwnerDataAccess().Get());
            return data;
        }
        public static BusOwnerModel Get(int id)
        {
            var config = new MapperConfiguration(c => c.CreateMap<User, BusOwnerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BusOwnerModel>(BusOwnerDataAccessFactory.BusOwnerDataAccess().Get(id));
            return data;
        }
        public static BusModel GetBusList(int id) //has issues with irepo
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusInfo, BusModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BusModel>(BusOwnerDataAccessFactory.BusOwnerDataAccess().Buslist(id));
            return data;
        }
        public static void Add(BusOwnerModel obj)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusOwnerModel, User>());
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(obj);
            BusOwnerDataAccessFactory.BusOwnerDataAccess().Add(data);
        }
        public static void Edit(BusOwnerModel obj)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusOwnerModel, User>());
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(obj);
            BusOwnerDataAccessFactory.BusOwnerDataAccess().Edit(data);
        }
        public static void Delete(int i)
        {

            BusOwnerDataAccessFactory.BusOwnerDataAccess().Delete(i);
        }
    }
}

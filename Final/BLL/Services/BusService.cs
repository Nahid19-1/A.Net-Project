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
    public class BusService
    {
        public static List<BusModel> Get()
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusInfo, BusModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BusModel>>(BusOwnerDataAccessFactory.BusDataAccess().Get());
            return data;
        }
        public static BusModel Get(int id)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusInfo, BusModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BusModel>(BusOwnerDataAccessFactory.BusDataAccess().Get(id));
            return data;
        }
        public static void Add(BusModel obj)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusModel, BusInfo>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BusInfo>(obj);
            BusOwnerDataAccessFactory.BusDataAccess().Add(data);
        }
        public static void Edit(BusModel obj)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusModel, BusInfo>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BusInfo>(obj);
            BusOwnerDataAccessFactory.BusDataAccess().Edit(data);
        }
        public static void Delete(int i)
        {
            
            BusOwnerDataAccessFactory.BusDataAccess().Delete(i);
        }
    }
}

using BLL.Entities;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace CBPresentation_API.Controllers
{
    public class BusOwnerController : ApiController
    {
        //Bus Owner cruds____________________________________________________________________

        [Route("api/BusOwner/viewBusOwners")]
        [HttpGet]
        public dynamic GetBusOwners()
        {
            var owners = BusOwnerService.Get();
            var data = new JavaScriptSerializer().Serialize(owners);
            return data;
        }

        [Route("api/BusOwner/viewBusOwner/{id}")]
        [HttpGet]
        public dynamic GetBusOwner(int id)
        {
            var owner = BusOwnerService.Get(id);
            var data = new JavaScriptSerializer().Serialize(owner);
            return data;
        }

        [Route("api/BusOwner/addBusOwner")]
        [HttpPost]
        public dynamic AddBusOwner(BusOwnerModel owner)
        {
            if (owner == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Could not add bus Owner");
            }
            else
            {
                BusOwnerService.Add(owner);
                return Request.CreateResponse(HttpStatusCode.OK, "Bus Owner Added");
            }
        }

        [Route("api/BusOwner/editBusOwner")]
        [HttpPost]
        public dynamic EditBusOwner(BusOwnerModel owner)
        {
            if (owner == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Could not edited");
            }
            else
            {
                BusOwnerService.Edit(owner);
                return Request.CreateResponse(HttpStatusCode.OK, "Bus Owner Edited");
            }
        }

        [Route("api/BusOwner/deleteBusOwner")]
        [HttpPost]
        public dynamic DeleteBusOwner(int i)
        {
            BusOwnerService.Delete(i);
            return Request.CreateResponse(HttpStatusCode.OK, "Bus Owner Deleted");
        }


        //Bus cruds____________________________________________________________________

        [Route("api/BusOwner/viewBuses")]
        [HttpGet]
        public dynamic GetBuses()
        {
            var buses = BusService.Get();
            var data = new JavaScriptSerializer().Serialize(buses);
            return data;
        }

        [Route("api/BusOwner/viewBus/{id}")]
        [HttpGet]
        public dynamic GetBus(int id)
        {
            var buses = BusService.Get(id);
            var data = new JavaScriptSerializer().Serialize(buses);
            return data;
        }

        [Route("api/BusOwner/addBus")]
        [HttpPost]
        public dynamic AddBus(BusModel bus)
        {
            if (bus == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Could not add bus");
            }
            else
            {
                BusService.Add(bus);
                return Request.CreateResponse(HttpStatusCode.OK, "Bus Added");
            }
        }

        [Route("api/BusOwner/editBus")]
        [HttpPost]
        public dynamic EditBus(BusModel bus)
        {
            if (bus == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Could not edited");
            }
            else
            {
                BusService.Edit(bus);
                return Request.CreateResponse(HttpStatusCode.OK, "Bus Edited");
            }
        }

        [Route("api/BusOwner/deleteBus")]
        [HttpPost]
        public dynamic DeleteBus(int i)
        {
            BusService.Delete(i);
            return Request.CreateResponse(HttpStatusCode.OK, "Bus Deleted");
        }


        //bus route cruds____________________________________________________________________

        [Route("api/BusOwner/viewRoutes")]
        [HttpGet]
        public dynamic GetRoutes()
        {
            var routes = BusRouteService.Get();
            var data = new JavaScriptSerializer().Serialize(routes);
            return data;
        }

        [Route("api/BusOwner/viewRoute/{id}")]
        [HttpGet]
        public dynamic GetRoute(int id)
        {
            var route = BusRouteService.Get(id);
            var data = new JavaScriptSerializer().Serialize(route);
            return data;
        }

        [Route("api/BusOwner/viewRoute/bus/{id}")]
        [HttpGet]
        public dynamic GetBusRoute(int id)
        {
            var route = BusRouteService.GetBusList(id);
            var data = new JavaScriptSerializer().Serialize(route);
            return data;
        }

        [Route("api/BusOwner/addRoute")]
        [HttpPost]
        public dynamic AddRoute(BusRouteModel route)
        {
            if (route == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Could not add route");
            }
            else
            {
                BusRouteService.Add(route);
                return Request.CreateResponse(HttpStatusCode.OK, "Route Added");
            }
        }

        [Route("api/BusOwner/editRoute")]
        [HttpPost]
        public dynamic EditRoute(BusRouteModel route)
        {
            if (route == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Could not edited");
            }
            else
            {
                BusRouteService.Edit(route);
                return Request.CreateResponse(HttpStatusCode.OK, "Route Edited");
            }
        }

        [Route("api/BusOwner/deleteRoute")]
        [HttpPost]
        public dynamic DeleteRoute(int i)
        {
            BusRouteService.Delete(i);
            return Request.CreateResponse(HttpStatusCode.OK, "Route Deleted");
        }
    }
}

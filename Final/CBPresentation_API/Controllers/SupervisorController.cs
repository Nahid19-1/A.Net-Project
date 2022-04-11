using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL.Services;
using DAL.Database;

namespace CBPresentation_API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class SupervisorController : ApiController
    {
        [Route("api/supervisor/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {

            var st = SupervisorService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }
    }
}

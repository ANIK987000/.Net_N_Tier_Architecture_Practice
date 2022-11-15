﻿using BusinessLoginLayer_BLL_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationApiLayer.Controllers
{
    public class StudentController : ApiController
    {
        [HttpGet]
        [Route("api/student/all")]

        public HttpResponseMessage GetAll()
        {
            var data = StudentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK,data);
        }
    }
}

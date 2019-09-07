using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FaultyServer.Controllers
{
    [RoutePrefix("api/errors")]
    public class ErrorsController : ApiController
    {
        readonly Random _rng;

        public ErrorsController()
        {
            _rng = new Random();
        }

        [HttpGet, Route("alwaysget")]
        public IHttpActionResult AlwaysGetError()
        {
            return InternalServerError(new Exception("Something unexpected happened in the server.  Please don't try again."));
        }

        [HttpPost, Route("always")]
        public IHttpActionResult AlwaysError()
        {
            return InternalServerError(new Exception("Something unexpected happened in the server.  Please don't try again."));
        }

        [HttpPost, Route("random")]
        public IHttpActionResult RandomlyError()
        {
            if (_rng.Next(100) > 50)
            {
                return InternalServerError(new Exception("Something randomly unexpected happened in the server."));
            }

            return Ok("Something randomly succeeded.");
        }
    }
}

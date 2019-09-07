using System.Web.Http;

namespace FaultyServer.Controllers
{
    [RoutePrefix("success")]
    public class SuccessController : ApiController
    {
        [HttpGet]
        public IHttpActionResult SuccessfulGet()
        {
            return Ok("This is a successful GET.");
        }

        [HttpPost]
        public IHttpActionResult SuccessfulPost()
        {
            return Ok("This is a successful POST.");
        }

        [HttpPut]
        public IHttpActionResult SuccessfulPut()
        {
            return Ok("This is a successful PUT.");
        }

        [HttpDelete]
        public IHttpActionResult SuccessfulDelete()
        {
            return Ok("This is a successful DELETE.");
        }
    }
}
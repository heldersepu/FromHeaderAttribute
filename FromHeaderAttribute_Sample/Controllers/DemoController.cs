using System.Web.Http;

namespace FromHeaderAttribute_Sample.Controllers
{
    [RoutePrefix("Demo")]
    public class DemoController : ApiController
    {
        [Route("Post")]
        public IHttpActionResult Post([FromHeader]string test)
        {
            return Ok(Request.Headers);
        }

        [Route("Put")]
        public IHttpActionResult Put([FromHeader(Name = "abc")]string test)
        {
            return Ok(Request.Headers);
        }
    }
}

using System.Web.Http;

namespace FromHeaderAttribute_Sample.Controllers
{
    [RoutePrefix("Demo")]
    public class DemoController : ApiController
    {
        [Route("")]
        public IHttpActionResult Post([FromHeader]string test)
        {
            return Ok(Request.Headers);
        }
    }
}

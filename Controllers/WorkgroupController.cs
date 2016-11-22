using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class WorkgroupController : Controller
    {
        [Route("names")]
        public List<string> Get(){
            return new List<string>{"hi", "you"};
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VerbTestPoc.EntityFramework;
using VerbTestPoc.Model;

namespace VerbTestWebAPI.Controllers
{
    public class VerbsController : ApiController
    {
        // GET api/verbs
        public IEnumerable<Verb> GetAll()
        {
            using (VerbTestContext context = new VerbTestContext())
            {
                return context.Verbs.ToList<Verb>();
            }
        }
    }
}

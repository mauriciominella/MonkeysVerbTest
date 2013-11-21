using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VerbTestPoc.EntityFramework;
using VerbTestPoc.Model;

namespace VerbTestWebAPI.Controllers
{
    public class TeamsController : ApiController
    {
        // GET api/teams
        public IEnumerable<Team> Get()
        {
            using (VerbTestContext context = new VerbTestContext())
            {
                return context.Teams.ToList<Team>();
            }
        }

    }
}

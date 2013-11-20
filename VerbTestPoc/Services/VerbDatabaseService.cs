using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerbTestPoc.EntityFramework;
using VerbTestPoc.Model;

namespace VerbTestPoc.Services
{
    public class VerbDatabaseService : VerbTestPoc.Services.IVerbDatabaseService
    {
        #region Members

        private VerbTestContext _dbContext;

        #endregion

        #region Constructors


        public VerbDatabaseService()
        {
            this._dbContext = new VerbTestContext();
        }

        #endregion  

        #region Public Methods

        public IList<Verb> GetAll()
        {
            return _dbContext.Verbs.ToList();
        }

        public void Add(Verb newVerb)
        {
            this._dbContext.Verbs.Add(newVerb);
        }

        public IList<Verb> GetFromPreviousTests(Team team)
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}

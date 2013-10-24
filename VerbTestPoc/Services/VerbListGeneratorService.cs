using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerbTestPoc.Model;

namespace VerbTestPoc.Services
{
    public class VerbListGeneratorService
    {
        #region Members

        private IVerbDatabaseService _verbDbService;

        #endregion

        #region Constructors

        public VerbListGeneratorService(IVerbDatabaseService verbDbService){
            this._verbDbService = verbDbService;
        }

        #endregion

        #region Public Methods

        public List<Verb> Generate(ListGenerationRequest request)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

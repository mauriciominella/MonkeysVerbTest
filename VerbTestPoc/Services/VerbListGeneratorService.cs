using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerbTestPoc.Common;
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

        public List<Verb> Generate()
        {
            List<Verb> finalList = new List<Verb>();

            finalList.AddRange(_verbDbService.GetAll().Where(v => v.Level == VerbLevel.Easy).Take(2).ToList());
            finalList.AddRange(_verbDbService.GetAll().Where(v => v.Level == VerbLevel.Medium).Take(5).ToList());
            finalList.AddRange(_verbDbService.GetAll().Where(v => v.Level == VerbLevel.Hard).Take(3).ToList());

            return finalList;

            //var verbs = (from t in _verbDbService.GetAll()
            //    select t).Take(10).Where;

            //return verbs.ToList<Verb>();
            
        }

        #endregion
    }
}


using System;
using System.Collections.Generic;
using VerbTestPoc.Model;
namespace VerbTestPoc.Services
{
    public interface IVerbDatabaseService
    {
        IList<Verb> GetAll();
    }
}

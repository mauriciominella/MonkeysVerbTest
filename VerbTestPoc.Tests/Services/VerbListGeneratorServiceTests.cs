using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VerbTestPoc.Services;
using VerbTestPoc.Model;
using System.Collections.Generic;
using FizzWare.NBuilder;

namespace VerbTestPoc.Tests.Services
{
    [TestClass]
    public class VerbListGeneratorServiceTests
    {
        [TestMethod]
        public void Given_A_Blue_Book_Request_Should_Return_Only_Blue_Book_Verbs()
        {

            //VerbListGeneratorService listGeneratorService = new VerbListGeneratorService(
        }
    }

    #region Fakes


    public class FakeVerbDatabaseService : IVerbDatabaseService{

        public IList<Verb> GetAll()
        {
            return Builder<Verb>.CreateListOfSize(10).All()
                .With(x => x.Book = Common.Books.Blue)
                .With(x => x.Active = true)
                .Build();

        }
    }

    #endregion
}

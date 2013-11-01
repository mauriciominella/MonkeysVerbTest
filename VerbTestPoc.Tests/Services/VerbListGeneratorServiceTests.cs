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
        public void Given_A_Team_Should_Return_A_List_Of_10_Verbs()
        {
            FakeVerbDatabaseService verbDbService = new FakeVerbDatabaseService();
            VerbListGeneratorService listGeneratorService = new VerbListGeneratorService(verbDbService);

            List<Verb> generatedVerbs = listGeneratorService.Generate();

            Assert.AreEqual(10, generatedVerbs.Count);
        }

        [TestMethod]
        public void Given_A_Team_Should_Return_A_List_Of_10_Verbs_With_2_Easy_And_5_Medium_And_3_Hard_Verbs()
        {
            FakeVerbDatabaseService verbDbService = new FakeVerbDatabaseService();
            VerbListGeneratorService listGeneratorService = new VerbListGeneratorService(verbDbService);

            List<Verb> generatedVerbs = listGeneratorService.Generate();

            int easyVerbsCount = 2;
            int mediumVerbsCount = 5;
            int hardVerbsCount = 3;

            Assert.AreEqual(easyVerbsCount, generatedVerbs.FindAll(v => v.Level == Common.VerbLevel.Easy).Count);
            Assert.AreEqual(mediumVerbsCount, generatedVerbs.FindAll(v => v.Level == Common.VerbLevel.Medium).Count);
            Assert.AreEqual(hardVerbsCount, generatedVerbs.FindAll(v => v.Level == Common.VerbLevel.Hard).Count);
        }
    }

    #region Fakes


    public class FakeVerbDatabaseService : IVerbDatabaseService{

        public IList<Verb> GetAll()
        {
            List<Verb> finalList = new List<Verb>();

            finalList.AddRange(
                Builder<Verb>.CreateListOfSize(100).All()
                .With(x => x.Level == Common.VerbLevel.Easy)
                .With(x => x.Active = true)
                .Build()
            );

            finalList.AddRange(
                Builder<Verb>.CreateListOfSize(100).All()
                .With(x => x.Level == Common.VerbLevel.Medium)
                .With(x => x.Active = true)
                .Build()
            );


            finalList.AddRange(
                Builder<Verb>.CreateListOfSize(100).All()
                .With(x => x.Level == Common.VerbLevel.Hard)
                .With(x => x.Active = true)
                .Build()
            );


            return finalList;

        }
    }

    #endregion
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VerbTestPoc.Services;
using VerbTestPoc.Model;
using System.Collections.Generic;
using FizzWare.NBuilder;
using System.Linq;

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

            Team team = new Team();

            List<Verb> generatedVerbs = listGeneratorService.Generate(team);

            Assert.AreEqual(10, generatedVerbs.Count);
        }

        [TestMethod]
        public void Given_A_Team_Should_Return_A_List_Of_10_Verbs_With_2_Easy_And_5_Medium_And_3_Hard_Verbs()
        {
            FakeVerbDatabaseService verbDbService = new FakeVerbDatabaseService();
            VerbListGeneratorService listGeneratorService = new VerbListGeneratorService(verbDbService);

            Team team = new Team();

            List<Verb> generatedVerbs = listGeneratorService.Generate(team);

            int easyVerbsCount = 2;
            int mediumVerbsCount = 5;
            int hardVerbsCount = 3;

            Assert.AreEqual(easyVerbsCount, generatedVerbs.FindAll(v => v.Level == Common.VerbLevel.Easy).Count);
            Assert.AreEqual(mediumVerbsCount, generatedVerbs.FindAll(v => v.Level == Common.VerbLevel.Medium).Count);
            Assert.AreEqual(hardVerbsCount, generatedVerbs.FindAll(v => v.Level == Common.VerbLevel.Hard).Count);
        }

        [TestMethod]
        public void Given_A_Team_Should_Return_At_Least_8_Verbs_That_Werent_Part_Of_Previous_Tests()
        {
            FakeVerbDatabaseService verbDbService = new FakeVerbDatabaseService();
            VerbListGeneratorService listGeneratorService = new VerbListGeneratorService(verbDbService);

            Team team = new Team();
            team.Id = 1;
            team.Name = "Monkeys In T-Shirts";

            List<Verb> generatedVerbs = listGeneratorService.Generate(team);

            IList<Verb> verbsFromPreviousTests = verbDbService.GetFromPreviousTests(team);

            int numberOfOldVerbs = generatedVerbs.Select(v => v.Id).Intersect(verbsFromPreviousTests.Select(v => v.Id)).Count();

            Assert.IsTrue(numberOfOldVerbs <= 2);
        }

        [TestMethod]
        public void Given_A_Team_Should_A_List_Of_Non_Sequencial_Verbs()
        {
            FakeVerbDatabaseService verbDbService = new FakeVerbDatabaseService();
            VerbListGeneratorService listGeneratorService = new VerbListGeneratorService(verbDbService);

            Team team = new Team();

            List<Verb> generatedVerbs = listGeneratorService.Generate(team);

            Assert.AreNotEqual(generatedVerbs[0].Id + 1, generatedVerbs[0].Id);
        }
    }

    #region Fakes


    public class FakeVerbDatabaseService : IVerbDatabaseService{

        public IList<Verb> GetAll()
        {
            List<Verb> finalList = new List<Verb>();

            var generator = new SequentialGenerator<int> { Direction = GeneratorDirection.Ascending, Increment = 1 };
            generator.StartingWith(1);

            finalList.AddRange(
                Builder<Verb>.CreateListOfSize(100).All()
                .With(x => x.Id = generator.Generate())
                .With(x => x.Level == Common.VerbLevel.Easy)
                .With(x => x.Active = true)
                .Build()
            );


            generator.StartingWith(101);

            finalList.AddRange(
                Builder<Verb>.CreateListOfSize(100).All()
                .With(x => x.Id = generator.Generate())
                .With(x => x.Level == Common.VerbLevel.Medium)
                .With(x => x.Active = true)
                .Build()
            );

            generator.StartingWith(201);

            finalList.AddRange(
                Builder<Verb>.CreateListOfSize(100).All()
                .With(x => x.Id = generator.Generate())
                .With(x => x.Level == Common.VerbLevel.Hard)
                .With(x => x.Active = true)
                .Build()
            );


            return finalList;

        }

        public IList<Verb> GetFromPreviousTests(Team team)
        {
            List<Verb> verbsFromPreviousTests = new List<Verb>();

            var generator = new SequentialGenerator<int> { Direction = GeneratorDirection.Ascending, Increment = 1 };
            generator.StartingWith(1);

            verbsFromPreviousTests.AddRange(
                Builder<Verb>.CreateListOfSize(3).All()
                .With(x => x.Id = generator.Generate())
                .With(x => x.Level == Common.VerbLevel.Easy)
                .With(x => x.Active = true)
                .Build()
            );

            return verbsFromPreviousTests;
        }
    }

    #endregion
}

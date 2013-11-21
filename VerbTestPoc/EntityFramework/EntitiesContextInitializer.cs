using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerbTestPoc.Model;

namespace VerbTestPoc.EntityFramework
{
    public class EntitiesContextInitializer : DropCreateDatabaseAlways<VerbTestContext>
    {
        protected override void Seed(VerbTestContext context)
        {
            AddVerbsLevels(context);
            AddVerbs(context);
            AddBooks(context);
            AddTeams(context);
            context.SaveChanges();

        }

        private static void AddVerbsLevels(VerbTestContext context)
        {
            List<VerbLevel> verbLevels = new List<VerbLevel>
            {
                new VerbLevel {VerbLevelId=1, Name="Easy"},
                new VerbLevel {VerbLevelId=2, Name="Medium"},
                new VerbLevel {VerbLevelId=3, Name="Hard"}
            };

            // add data into context and save to db
            foreach (VerbLevel vl in verbLevels)
            {
                context.VerbLevels.Add(vl);
            }
        }

        private static void AddVerbs(VerbTestContext context)
        {
            List<Verb> verbs = new List<Verb>
            {
                new Verb {VerbId=1, Infinitive="put", VerbLevelId=1},
                new Verb {VerbId=2, Infinitive="cut", VerbLevelId=2},
                new Verb {VerbId=3, Infinitive="set", VerbLevelId=3}
            };

            // add data into context and save to db
            foreach (Verb v in verbs)
            {
                context.Verbs.Add(v);
            }
        }

        private static void AddBooks(VerbTestContext context)
        {
            List<Book> books = new List<Book>
            {
                new Book {BookId=1, Name = "Red" },
                new Book {BookId=2,  Name = "Blue" }
            };

            // add data into context and save to db
            foreach (Book b in books)
            {
                context.Books.Add(b);
            }
        }

        private static void AddTeams(VerbTestContext context)
        {
            List<Team> teams = new List<Team>
            {
                new Team {TeamId=1,  Name="Monkeys In T-Shirts", BookId = 2 },
                new Team {TeamId=2,  Name="Lioncow", BookId = 2 },
                new Team {TeamId=3,  Name="Horseal", BookId = 2 },
                new Team {TeamId=4,  Name="Foxewe", BookId = 1 },
                new Team {TeamId=5,  Name="Rubble Fish", BookId = 1 },
                new Team {TeamId=6,  Name="Turkeywolf", BookId = 2 },
                new Team {TeamId=7,  Name="The Russian Owls", BookId = 1 }
            };

            // add data into context and save to db
            foreach (Team t in teams)
            {
                context.Teams.Add(t);
            }
        }
    }
}

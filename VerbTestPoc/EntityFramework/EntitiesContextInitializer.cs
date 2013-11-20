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
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerbTestPoc.Model;

namespace VerbTestPoc.EntityFramework
{
    public class VerbTestContext : DbContext
    {
        public VerbTestContext()
        {
//            ((IObjectContextAdapter)context)
//.ObjectContext.ContextOptions.LazyLoadingEnabled = false;

            this.Configuration.LazyLoadingEnabled = false;

            //((IObjectContextAdapter)context)
            //        .ObjectContext.ContextOptions.ProxyCreationEnabled = false;

            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Verb> Verbs { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<WeekDay> WeekDays { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<VerbLevel> VerbLevels { get; set; }
    }
}

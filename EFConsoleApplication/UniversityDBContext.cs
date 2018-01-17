using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EFConsoleApplication
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext() : base("name=UniversityContext")
        {

        }

        public DbSet<Student> Students{ get; set; }
        public DbSet<Course> Courses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention > ();
        }

    }
}

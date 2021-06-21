using System.Data.Entity;


namespace OOPRecords.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(string dbName) : base(dbName)
        {
            Database.SetIntializer(new Initializer());
        }

        public DbSet<Student> Students { get; set; }
    }
}

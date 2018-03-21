namespace PeopleData
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PeopleEntities : DbContext
    {
        //public PeopleEntities()
        //    : base("name=PeopleEntities")
        //{
        //}

        public PeopleEntities(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

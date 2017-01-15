namespace CustomerAPITest
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using MySql.Data.Entity;

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public partial class CustomerContextModel : DbContext
    {
        public CustomerContextModel()
            : base("name=CustomerContextModel")
        {
        }

        public virtual DbSet<customer> customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<customer>()
                .Property(e => e.customer_name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.region_state)
                .IsUnicode(false);
        }
    }
}

namespace BookExamples.Areas.Chapter08.Models.MyDb2Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyDb2 : DbContext
    {
        public MyDb2()
            : base("name=MyDb2")
        {
        }
        public virtual DbSet<MyTable1> MyTable1 { get; set; }
        public virtual DbSet<MyTable2> MyTable2 { get; set; }
        public virtual DbSet<MyTable3> MyTable3 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyTable1>()
                .Property(e => e.KeChengID)
                .IsFixedLength();

            modelBuilder.Entity<MyTable1>()
                .HasMany(e => e.MyTable3)
                .WithRequired(e => e.MyTable1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MyTable2>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<MyTable2>()
                .HasMany(e => e.MyTable3)
                .WithRequired(e => e.MyTable2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MyTable3>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<MyTable3>()
                .Property(e => e.KeChengID)
                .IsFixedLength();
        }
    }
}
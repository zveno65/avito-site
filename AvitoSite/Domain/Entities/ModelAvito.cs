namespace Domain.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelAvito : DbContext
    {
        public ModelAvito()
            : base("name=ModelAvito")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<An> Ans { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Liked> Likeds { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(e => e.Liked)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.An)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<An>()
                .HasMany(e => e.Liked)
                .WithRequired(e => e.An)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<An>()
                .HasMany(e => e.Photo)
                .WithRequired(e => e.An)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.An)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);
        }
    }
}

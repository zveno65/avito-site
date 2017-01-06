namespace Domain.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelAvito : DbContext
    {
        public ModelAvito()
            : base("name=ModelAvito1")
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<An> An { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Liked> Liked { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

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

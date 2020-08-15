namespace DbBliblioteca
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DbBliblioteca.Entities;

    public partial class ContextBlibliotecaVirtual : DbContext
    {
        public ContextBlibliotecaVirtual()
            : base("name=ContextBlibliotecaVirtual")
        {
        }

        public virtual DbSet<CLIENT> CLIENT { get; set; }
        public virtual DbSet<MASTER_DATA> MASTER_DATA { get; set; }
        public virtual DbSet<MASTER_TYPE> MASTER_TYPE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENT>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ADDRESS_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<MASTER_DATA>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MASTER_DATA>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CITY>()
                .HasMany(e => e.CLIENT)
                .WithOptional(e => e.CITY)
                .HasForeignKey(e => e.FK_CITY_ID);

            modelBuilder.Entity<MASTER_DATA>()
                .HasMany(e => e.CLIENT1)
                .WithOptional(e => e.MASTER_DATA1)
                .HasForeignKey(e => e.FK_TYPE_CLIENT);

            modelBuilder.Entity<MASTER_TYPE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MASTER_TYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);
        }
    }
}

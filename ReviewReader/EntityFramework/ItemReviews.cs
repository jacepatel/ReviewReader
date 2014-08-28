namespace TextReader.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ItemReviews : DbContext
    {
        public ItemReviews()
            : base("name=ItemReviews")
        {
        }

        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<review> reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<item>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<review>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<review>()
                .Property(e => e.ShortReview)
                .IsUnicode(false);

            modelBuilder.Entity<review>()
                .Property(e => e.ReviewerId)
                .IsUnicode(false);

            modelBuilder.Entity<review>()
                .Property(e => e.ReviewLocation)
                .IsUnicode(false);
        }
    }
}

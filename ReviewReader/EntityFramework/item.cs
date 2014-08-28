namespace TextReader.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("inb302.items")]
    public partial class item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemId { get; set; }

        [Required]
        [StringLength(200)]
        public string ItemName { get; set; }

        public int TotalReviews { get; set; }

        public int FiveStarReviews { get; set; }

        public int FourStarReviews { get; set; }

        public int ThreeStarReviews { get; set; }

        public int TwoStarReviews { get; set; }

        public int OneStarReviews { get; set; }
    }
}

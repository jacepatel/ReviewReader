namespace TextReader.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("inb302.reviews")]
    public partial class review
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReviewId { get; set; }

        public int? ItemId { get; set; }

        [Required]
        [StringLength(200)]
        public string ItemName { get; set; }

        public int ReviewersOfReview { get; set; }

        public int ReviewersOfReviewFoundHelpful { get; set; }

        public int StarsGiven { get; set; }

        [StringLength(500)]
        public string ShortReview { get; set; }

        [StringLength(100)]
        public string ReviewerId { get; set; }

        [StringLength(100)]
        public string ReviewLocation { get; set; }

        [Column(TypeName = "bit")]
        public bool? IsAmazonVerifiedPurchase { get; set; }
    }
}

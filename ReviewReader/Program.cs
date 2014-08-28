using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using TextReader.EntityFramework;
using TextReader;

namespace ReviewReader
{
    static class Program
    {
        public class Review
        {
            public int ReviewersOfReview { get; set; }
            public int ReviewersOfReviewFoundHelpful { get; set; }
            public decimal StarsGiven { get; set; }
            public string ShortReview { get; set;}
            public string ReviewDate { get; set; }
            public string Reviewer { get; set; }
            public string ReviewLocation { get; set; }
            public bool IsAmazonVerifiedPurchase { get; set; }
            public string ReviewItem { get; set; }
            public string LongReview { get; set; }
        }
        //[Table(Name = "Items")]
        public class Item
        {
            public string ItemName { get; set; }
            public int NoOfReviews { get; set; }
            public int FiveStar { get; set; }
            public int FourStar { get; set; }
            public int ThreeStar { get; set; }
            public int TwoStar { get; set; }
            public int OneStar { get; set; }
            public List<Review> Reviews { get; set; }
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //string file = "C:\\Users\\jacep_000\\Downloads\\Amazon Review Dataset.txt";
            //ReadFile(file);
            
        }

        

        public static void ReadFile(string file)
        {
            int counter = 0;
            string line;
            bool isItemHead = false;
            bool nextLineIsItemName = false;
            bool nextLineIsTotalReview = false;
            bool nextLineIsFiveStar = false;
            bool isReviews = false;
            bool nextLineIsShortReview = false;
            bool nextLineIsReviewer = false;
            bool nextLineIsLongReview = false;
            int reviewLine = 0;
            List<Item> allItems = new List<Item>();

            Item reviewItem = new Item();
            List<Review> reviewsForItem = new List<Review>();
            Review itemReview = new Review();

            // Read the file and display it line by line.
            System.IO.StreamReader fileRead =
               new System.IO.StreamReader(file);

            while ((line = fileRead.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    counter++;
                    continue;
                    //Skips WhiteSpace
                }
                if (isItemHead)
                {
                    if (line.Trim() == "© 1996-2012, Amazon.com, Inc. or its affiliates")
                    {
                        
                        isItemHead = false;
                        allItems.Add(reviewItem);
                        reviewsForItem = new List<Review>();
                        reviewItem = new Item();
                        isReviews = false;
                        counter++;
                        continue;
                    }

                    if (isReviews)
                    {
                        try
                        {
                            if (nextLineIsLongReview)
                            {
                                line = line.Trim();

                                if (line == "Help other customers find the most helpful reviews")
                                {
                                    nextLineIsLongReview = false;
                                    counter++;
                                    continue;
                                }

                                itemReview.LongReview = itemReview.LongReview + " " + line;
                                counter++;
                                continue;
                            }
                            if (line.IndexOf("This review is from: ") > -1)
                            {
                                itemReview.ReviewItem = line.Trim().Substring(21, line.Trim().Length - 21);
                                counter++;
                                nextLineIsLongReview = true;
                                continue;
                            }
                            if (nextLineIsReviewer)
                            {
                                line = line.Trim();
                                if (line.IndexOf("(") > 0 && line.IndexOf(")") > 0)
                                {
                                    int start = line.IndexOf("(") + 1;
                                    int end = line.IndexOf(")", start);
                                    itemReview.ReviewLocation = line.Substring(start, end - start);
                                    itemReview.Reviewer = line.Substring(3, start);
                                    counter++;
                                    nextLineIsReviewer = false;
                                    continue;
                                }
                                if (line.IndexOf("-") > -1)
                                {
                                    itemReview.Reviewer = line.Substring(3, line.IndexOf("-"));
                                }
                                else
                                {
                                    itemReview.Reviewer = line.Trim();
                                }

                                itemReview.ReviewLocation = "Unknown";
                                counter++;
                                nextLineIsReviewer = false;
                                continue;

                            }
                            if (nextLineIsShortReview)
                            {
                                line = line.Trim();
                                int ix1 = line.LastIndexOf(',');
                                int ix2 = ix1 > 0 ? line.LastIndexOf(',', ix1 - 1) : -1;
                                itemReview.ReviewDate = line.Substring(ix2 + 2, line.Length - (ix2 + 2));
                                itemReview.ShortReview = line.Substring(0, ix2);
                                nextLineIsReviewer = true;
                                nextLineIsShortReview = false;
                                counter++;
                                continue;
                            }
                            if (line.Trim().IndexOf("found the following review helpful:") > -1)
                            {
                                int space1 = line.Trim().IndexOf(" ");
                                int space2 = line.Trim().IndexOf(" ", space1 + 1);
                                int space3 = line.Trim().IndexOf(" ", space2 + 1);
                                itemReview.ReviewersOfReviewFoundHelpful = Convert.ToInt16(line.Trim().Substring(0, space1).Replace(",", ""));
                                itemReview.ReviewersOfReview = Convert.ToInt16(line.Trim().Substring(space2 + 1, space3 - space2).Replace(",", ""));
                                counter++;
                                continue;
                            }
                            if (line.Trim().IndexOf("out of 5 stars") > -1 && line.Trim().IndexOf("customer reviews") == -1)
                            {

                                itemReview.StarsGiven = Convert.ToDecimal(line.Trim().Substring(0, 3));
                                nextLineIsShortReview = true;
                                counter++;
                                continue;
                            }

                            if (line.IndexOf("| PermalinkComment") > 0)
                            {
                                //END OF REVIEW
                                reviewsForItem.Add(itemReview);
                                reviewItem.Reviews = reviewsForItem;
                                itemReview = new Review();
                                counter++;
                                continue;
                            }
                        }
                        catch (Exception ex)
                        {
                            //Add in some error handling about what we missed here
                            isItemHead = false;
                            nextLineIsItemName = false;
                            nextLineIsTotalReview = false;
                            nextLineIsFiveStar = false;
                            isReviews = false;
                            nextLineIsShortReview = false;
                            nextLineIsReviewer = false;
                            nextLineIsLongReview = false;
                            counter++;
                            continue;

                        }
                    }
                    

                    if (line.Trim() == "Most Helpful First | Newest First")
                    {
                        isReviews = true; 
                    }

                    if (nextLineIsFiveStar)
                    {
                        if (line.Trim().Substring(0, 1) == "(")
                        {
                         
                            int start = line.IndexOf("(") + 1;
                            int end = line.IndexOf(")", start);
                            if (reviewLine == 0)
                                reviewItem.FiveStar = Convert.ToInt16(line.Substring(start, end - start));
                            if (reviewLine ==1)
                                reviewItem.FourStar = Convert.ToInt16(line.Substring(start, end - start));
                            if (reviewLine == 2)
                                reviewItem.ThreeStar = Convert.ToInt16(line.Substring(start, end - start));
                            if (reviewLine == 3)
                                reviewItem.TwoStar = Convert.ToInt16(line.Substring(start, end - start));
                            if (reviewLine == 4)
                            {
                                reviewItem.OneStar = Convert.ToInt16(line.Substring(start, end - start));
                                nextLineIsFiveStar = false;
                                reviewLine = 0;
                                counter++;
                                continue;
                            }
                            reviewLine++;
                            counter++;
                            continue;
                        }
                        counter++;
                        continue;
                    }
                    if (nextLineIsTotalReview)
                    {
                        //SET TOTAL REVIEWS
                        //line.Trim()
                        reviewItem.NoOfReviews = Convert.ToInt16(line.Trim().Substring(0, line.Trim().IndexOf(" ")));
                        nextLineIsTotalReview = false;
                        nextLineIsFiveStar = true;
                        counter++;
                        continue;
                    }
                    if (nextLineIsItemName)
                    {
                        //SET ITEM NAME
                        reviewItem.ItemName = line;
                        nextLineIsItemName = false;
                        nextLineIsTotalReview = true;
                        counter++;
                        continue;
                    }
                    if (line.Trim() == "Customer Reviews")
                    {
                        nextLineIsItemName = true;
                        counter++;
                        continue;
                    }
                }
                if (line.IndexOf("Amazon.com: Customer Reviews:") > -1)
                {
                        isItemHead = true;
                        counter++;
                        continue;
                        //THIS IS THE BEGINING OF ITEM
                }
                counter++;
            }

            //Write allItems to the db here
            fileRead.Close();

            //Writing the files to the db
            //This needs handling for a lot of shit
            using (var db = new ItemReviews())
            {
                int itemidcounter = 1;
                int reviewidcounter = 1;
                foreach (Item i in allItems)
                {
                    var item = new TextReader.EntityFramework.item
                    {
                        ItemId = itemidcounter,
                        ItemName = i.ItemName,
                        OneStarReviews = i.OneStar,
                        TwoStarReviews = i.TwoStar,
                        ThreeStarReviews = i.ThreeStar,
                        FourStarReviews = i.FourStar,
                        FiveStarReviews = i.FiveStar,
                        TotalReviews = i.NoOfReviews
                    };
                    itemidcounter++;
                    foreach (Review r in i.Reviews)
                    {
                        var review = new TextReader.EntityFramework.review
                        {
                            ItemId = itemidcounter,
                            IsAmazonVerifiedPurchase = r.IsAmazonVerifiedPurchase,
                            ItemName = r.ReviewItem,
                            ReviewId = reviewidcounter,
                            ReviewersOfReview = r.ReviewersOfReview,
                            ReviewersOfReviewFoundHelpful = r.ReviewersOfReviewFoundHelpful,
                            ReviewLocation = r.ReviewLocation,
                            ShortReview = r.ShortReview,
                            StarsGiven =  Convert.ToInt32(r.StarsGiven),
                            ReviewerId = r.Reviewer
                        };
                        reviewidcounter++;
                        db.reviews.Add(review);
                    }
                    db.items.Add(item);
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (DbEntityValidationException dbEx)
                    {
                        //Add some handling yo
                    }
                }
                
            }

            // Suspend the screen.
            Console.ReadLine();

        }
    }
}

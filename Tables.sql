
CREATE TABLE Items (
ItemId int NOT NULL PRIMARY KEY,
ItemName varchar(200) NOT NULL,
TotalReviews INT NOT NULL,
FiveStarReviews INT NOT NULL,
FourStarReviews INT NOT NULL,
ThreeStarReviews INT NOT NULL,
TwoStarReviews INT NOT NULL,
OneStarReviews INT NOT NULL)

	

CREATE TABLE Reviews (
	ReviewId INT NOT NULL PRIMARY KEY,
	ItemId INT,
	ItemName VARCHAR(200) NOT NULL,
	ReviewersOfReview INT NOT NULL,
	ReviewersOfReviewFoundHelpful INT NOT NULL,
	StarsGiven INT NOT NULL,
	ShortReview VARCHAR(500),
	ReviewerId VARCHAR(100),
	ReviewLocation VARCHAR(100),
	IsAmazonVerifiedPurchase BIT,
	ItemName 
	)
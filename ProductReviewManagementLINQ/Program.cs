using System;
using System.Collections;
using System.Collections.Generic;

namespace ProductReviewManagementLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product review management problem statement`");
            List<ProductReview> productReviews = new List<ProductReview>();
            {
                productReviews.Add(new ProductReview() { productId = 1, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                productReviews.Add(new ProductReview() { productId = 1, userId = 2, rating = 3, isLike = "Yes", review = "Awesome" });
                productReviews.Add(new ProductReview() { productId = 1, userId = 3, rating = 4, isLike = "Yes", review = "Awesome" });
                productReviews.Add(new ProductReview() { productId = 1, userId = 4, rating = 3, isLike = "Yes", review = "Nice" });
                productReviews.Add(new ProductReview() { productId = 1, userId = 5, rating = 4, isLike = "Yes", review = "Good" });
                productReviews.Add(new ProductReview() { productId = 2, userId = 1, rating = 1, isLike = "No", review = "Unsatifactory" });
                productReviews.Add(new ProductReview() { productId = 2, userId = 2, rating = 3, isLike = "Yes", review = "Good" });
                productReviews.Add(new ProductReview() { productId = 2, userId = 3, rating = 4, isLike = "Yes", review = "Awesome" });
                productReviews.Add(new ProductReview() { productId = 2, userId = 4, rating = 3, isLike = "Yes", review = "Nice" });
                productReviews.Add(new ProductReview() { productId = 2, userId = 5, rating = 4, isLike = "Yes", review = "Good" });
                productReviews.Add(new ProductReview() { productId = 3, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                productReviews.Add(new ProductReview() { productId = 3, userId = 2, rating = 3, isLike = "Yes", review = "Awesome" });
                productReviews.Add(new ProductReview() { productId = 3, userId = 3, rating = 4, isLike = "Yes", review = "Awesome" });
                productReviews.Add(new ProductReview() { productId = 3, userId = 4, rating = 3, isLike = "Yes", review = "Nice" });
                productReviews.Add(new ProductReview() { productId = 3, userId = 5, rating = 4, isLike = "Yes", review = "Good" });
                productReviews.Add(new ProductReview() { productId = 4, userId = 1, rating = 1, isLike = "No", review = "Unsatifactory" });
                productReviews.Add(new ProductReview() { productId = 4, userId = 2, rating = 2, isLike = "No", review = "Bad" });
                productReviews.Add(new ProductReview() { productId = 4, userId = 3, rating = 2, isLike = "No", review = "Worst" });
                productReviews.Add(new ProductReview() { productId = 4, userId = 4, rating = 3, isLike = "No", review = "Not good" });
                productReviews.Add(new ProductReview() { productId = 4, userId = 5, rating = 2, isLike = "No", review = "Okay" });
                productReviews.Add(new ProductReview() { productId = 5, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                productReviews.Add(new ProductReview() { productId = 5, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                productReviews.Add(new ProductReview() { productId = 5, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                productReviews.Add(new ProductReview() { productId = 5, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                productReviews.Add(new ProductReview() { productId = 5, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                productReviews.Add(new ProductReview() { productId = 9, userId = 1, rating = 5, isLike = "Yes", review = "Does the work" });
            }
            Console.WriteLine("##################################################");
            //UC2
            Manage.GetTop3HighestRatedRecords(productReviews);
            Console.WriteLine("##################################################");
            //UC3
            Manage.RatingGreaterThan3(productReviews);
            Console.WriteLine("##################################################");
            //UC4
            Manage.CountforeachProductId(productReviews);
            Console.WriteLine("##################################################");
            //UC5
            Manage.RetrieveProductID(productReviews);
            Console.WriteLine("##################################################");
        }
    }
}

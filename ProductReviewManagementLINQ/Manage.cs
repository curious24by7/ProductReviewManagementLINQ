using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewManagementLINQ
{
    class Manage
    {
        //UC2
        public static ArrayList GetTop3HighestRatedRecords(List<ProductReview> productReviews)
        {
            ArrayList outputList = new ArrayList();
            var highestRatedRows = (from rec in productReviews
                                    orderby rec.rating descending
                                    select rec).Take(3);
            foreach (var row in highestRatedRows)
            {
                Console.WriteLine(row.ToString());
                outputList.Add(row.ToString());
            }
            return outputList;
        }
        //UC3
        public static ArrayList RatingGreaterThan3(List<ProductReview> productReviews)
        {
            ArrayList outputList = new ArrayList();

            var records = (from rec in productReviews
                           where rec.rating > 3 && (rec.productId == 1 || rec.productId == 3 || rec.productId == 9)
                           select rec);
            foreach (var row in records)
            {
                Console.WriteLine(row.ToString());
                outputList.Add(row.ToString());
            }
            return outputList;
        }
        //UC4
        public static ArrayList CountforeachProductId(List<ProductReview> productReviews)
        {
            ArrayList outputList = new ArrayList();
            var records = (from rec in productReviews
                           group rec by rec.productId into g
                           select new
                           {
                               productId2 = g.Key,
                               ReviewCount = g.Count()
                           });
            foreach (var row in records)
            {
                Console.WriteLine(row.ToString());
                outputList.Add(row.ToString());
            }
            return outputList;
        }
        //UC5
        public static ArrayList RetrieveProductID(List<ProductReview> productReviews)
        {
            ArrayList outputList = new ArrayList();
            var records = (from rec in productReviews
                           select new { rec.productId, rec.review });
            foreach(var element in records)
            {
                Console.WriteLine(element.ToString());
                outputList.Add(element.ToString());
            }
            return outputList;
        }
        //UC6
        public static ArrayList SkipTopFive(List<ProductReview> productReviews)
        {
            ArrayList outputList = new ArrayList();
            var records = (from rec in productReviews
                           orderby rec.rating descending
                           select rec);
            foreach (var element in records.Skip(5))
            {
                Console.WriteLine(element.ToString());
                outputList.Add(element.ToString());
            }
            return outputList;
        }
    }
}

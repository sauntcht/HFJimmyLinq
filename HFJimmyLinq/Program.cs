﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace HFJimmyLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var done = false;
            while (!done)
            {
                Console.WriteLine(
                    "\nPress G to group comics by price, R to get reviews, any other key to quit.\n");
                switch (Console.ReadKey(true).KeyChar.ToString().ToUpper())
                {
                    case "G":
                        done = GroupComicsByPrice();
                        break;
                    case "R":
                        done = GetReview();
                        break;
                    default:
                        done = true;
                        break;
                }

            }

        }
        private static bool GroupComicsByPrice()
        {
            var groups = ComicAnalyzer.GroupComicsByPrice(Comic.Catalog, Comic.Prices);
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} comics:");
                foreach (var comic in group)
                    Console.WriteLine($"#{comic.Issue} {comic.Name}: {Comic.Prices[comic.Issues]:c}");
            }
            return false;
        }
        private static bool GetReview()
        {
            var reviews = ComicAnalyzer.GetReview(Comic.Catalog, Comic.Reviews);
            foreach(var review in reviews)
                Console.WriteLine(review);

            return false;
        }
    }
}

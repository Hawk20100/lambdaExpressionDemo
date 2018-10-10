﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaExpressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //number => number * number

            // Func<int, int> square = number => number * number;
            //const int factor = 5;
            //Func<int, int> multipler = n => n * factor;
            //var result = multipler(10);

            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            Console.ReadLine();
        }

        //static bool IsCheaperThan10Dollars(Book book)
        //{
        //    return book.Price < 10;
        //}
    }
}

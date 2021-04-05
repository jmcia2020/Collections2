using LendingLibrary.Collections;
using LendingLibrary.Models;
using System;

namespace LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Backpack<Book> books = new Backpack<Book>();
            books.Pack(new Book { Title = "Grapes of Wrath" });

            foreach (Book book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}

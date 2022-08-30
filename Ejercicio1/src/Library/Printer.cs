using System;
using System.Collections.Generic;

namespace SRP
{
    public class Print
    {
        public static void ListBooks(Shelf targetshelf)
        {
            foreach (Book shelvedbook in targetshelf.BookCatalogue)
            {
                Console.WriteLine($"El libro {shelvedbook.Title} por {shelvedbook.Author}, codigo {shelvedbook.Code}, esta en el estante {targetshelf.Sector}{targetshelf.Floor}");
            }
        }
    }
}
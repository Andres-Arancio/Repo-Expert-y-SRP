using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            
            Shelf shelf1 = new Shelf("A","7");
            Shelf shelf2 = new Shelf("B","3");

            /*
            <comment>
            Removiendo llamado a metodo del build anterior
            </comment>
            book1.ShelveBook("A","7");
            book2.ShelveBook("B","3");
            */

            /*
            <summary>
            Agregando los libros a sus respectivas estanterias
            </summary>
            */
            shelf1.AddBook(book1);
            shelf2.AddBook(book2);

            /*
            <summary>
            Tester
            </summary>
            */
            Print.ListBooks(shelf1);
            Print.ListBooks(shelf2);

        }
    }
}
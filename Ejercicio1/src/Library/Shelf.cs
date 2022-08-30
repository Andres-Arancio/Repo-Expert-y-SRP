using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelf
    {
        /*
        <summary>
        Declarando los atributos de una estanteria
        </summary>
        */
        public string Sector {get ; set ;}
        public string Floor {get ; set ;}
        public List<Book> BookCatalogue {get ; set ;}

        /*
        <summary>
        Constructor de estanteria
        </summary>
        */
        public Shelf(string sector, string floor)
        {
            this.Sector = sector;
            this.Floor = floor;
            this.BookCatalogue = new List<Book>();
        }

        /*
        <summary>
        Metodo que permite agregar un libro a una estanteria
        </summary>
        */
        public void AddBook(Book newbook)
        {
            this.BookCatalogue.Add(newbook);
        }
    }
}
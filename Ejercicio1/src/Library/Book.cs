
using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        
        /*
        <observation>
        Los parametros LibrarySector y LibraryShelve requieren que la informacion de la ubicacion del libro este en si mismo, cuando no deberia tener esa responsabilidad
        </observation>
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        */

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        /*
        <observation>
        La clase "Book" no deberia tener como responsabilidad el manejar su ubicacion en la biblioteca
        </observation>
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        */

    }
}
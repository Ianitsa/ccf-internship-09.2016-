using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_and_value_types_examples
{
    class Book
    {
        //These Fields should be private and used via properties. These are set this way for the example
        public decimal Price;
        public string Title;
        public string Author;

        public DateTime ReleaseDate;

        public Book(decimal price, string title, string author, DateTime releaseDate)
        {
            this.Price = price;
            this.Title = title;
            this.Author = author;
            this.ReleaseDate = releaseDate;
        }

        public TimeSpan Age
        {
            get
            {
                return DateTime.Now - ReleaseDate;
            }
        }
    }
}

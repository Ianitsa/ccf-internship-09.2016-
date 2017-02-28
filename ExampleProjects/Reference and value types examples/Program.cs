using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_and_value_types_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            StructWithClass_Example();

            //Console.WriteLine();
            //Class_Example();

            //Console.WriteLine();
            //StructWithClass_Example();

            Console.ReadLine();
        }

        static void Struct_Example()
        {
            Coordinates firstCoords = new Coordinates(Math.PI / 2, 1);

            Coordinates secondCoords = firstCoords;

            Console.WriteLine("Equality before change of second struct object: " + firstCoords.Equals(secondCoords));

            secondCoords.X = Math.PI / 6;
            secondCoords.Y = 0.5;

            Console.WriteLine("Equality after change of second struct object: " + firstCoords.Equals(secondCoords));

            Console.WriteLine(string.Format("Sin({0:F2}) = {1:F1}; \nSin({2:F2}) = {3:F1}", firstCoords.X, firstCoords.Y, secondCoords.X, secondCoords.Y));
        }

        static void Class_Example()
        {
            Book firstBook = new Book(19m, "Harry Potter and the philosopher's stone", "J. K. Rowling", new DateTime(1997, 7, 26));

            Book secondBook = firstBook;

            Console.WriteLine("Equality before change of second reference type object: " + firstBook.Equals(secondBook));

            secondBook.Title = "Harry Potter and the chamber of secrets";
            secondBook.ReleaseDate = new DateTime(1998, 7, 2);

            Console.WriteLine("Equality after change of second reference type object: " + firstBook.Equals(secondBook));

            Console.WriteLine(string.Format("Title: {1}\nAuthor: {2}\nPrice: {0:C}\nRelease Date: {3:d MMM yyyy} (Age: {4:F0} years)",
                firstBook.Price,
                firstBook.Title,
                firstBook.Author,
                firstBook.ReleaseDate,
                firstBook.Age.TotalDays / 365));

            Console.WriteLine();
            RefExample(secondBook);
            Console.WriteLine("The object is nullified after non-ref method: " + (secondBook == null));

            RefExample(ref secondBook);
            Console.WriteLine("The object is nullified after ref method: " + (secondBook == null));

            string s = "Hi there";

            Console.WriteLine("\n" + s);
            RefExample(s);
            Console.WriteLine("The string is nullified after non-ref method: " + (s == null));

            RefExample(ref s);
            Console.WriteLine("The string is nullified after ref method: " + (s == null));
        }

        static void StructWithClass_Example()
        {
            Book exBook = new Book(19m, "Harry Potter and the philosopher's stone", "J. K. Rowling", new DateTime(1997, 7, 26));

            StructWithClassObject firstStructObject = new StructWithClassObject(1, exBook);
            StructWithClassObject SecondStructObject = firstStructObject;

            Console.WriteLine("Equality before change of second object: " + firstStructObject.Equals(SecondStructObject));

            SecondStructObject.BookObject.Price = 20m;

            Console.WriteLine("Equality after change of second struct reference type object: " + firstStructObject.Equals(SecondStructObject));

            //SecondStructObject.IdentificationNumber = 2;

            //Console.WriteLine("Equality after change of second struct value type object: " + firstStructObject.Equals(SecondStructObject));

            SecondStructObject.BookObject = new Book(19m, "Harry Potter and the philosopher's stone", "J. K. Rowling", new DateTime(1997, 7, 26)); ;

            Console.WriteLine("Equality after change of second struct value type object: " + firstStructObject.Equals(SecondStructObject));
        }

        #region RefExamples

        static void RefExample(Book bookParam)
        {
            bookParam = null;
        }

        static void RefExample(ref Book bookParam)
        {
            bookParam = null;
        }

        static void RefExample(string str)
        {
            str = null;
        }

        static void RefExample(ref string str)
        {
            str = null;
        }

        #endregion RefExamples


        #region OutExamples

        static void OutExample(out Book bookParam)
        {
            bookParam = null;
        }

        static void OutExample(out string str)
        {
            str = "Outed string";
        }

        #endregion OutExamples
    }
}

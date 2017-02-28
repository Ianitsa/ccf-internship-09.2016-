using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_and_value_types_examples
{
    struct StructWithClassObject
    {
        //These Fields should be private and used via properties. These are set this way for the example
        public int IdentificationNumber;
        public Book BookObject;

        public StructWithClassObject(int id, Book bookObject)
        {
            this.IdentificationNumber = id;
            this.BookObject = bookObject;
        }
    }
}

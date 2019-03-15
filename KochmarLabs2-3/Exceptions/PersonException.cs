using System;

namespace KochmarLabs2_3.Exceptions
{
    class PersonException
    {
        
        internal class MaybeDiedPersonException : Exception
        {
            public MaybeDiedPersonException()
                : base("Person is toooo olddddd")
            {}
        }

        internal class NotEvenBorn : Exception
        {
            public NotEvenBorn()
                : base("Person hasn`t been born yet")
            {}
        }

        internal class EmailException : Exception
        {
            public EmailException()
                :base("Invalid email")
            {}
        }

     
    }
}

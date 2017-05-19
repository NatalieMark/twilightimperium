using System;
namespace Eksamensopgave2017
{
    public class WrongValueException : Exception
    {
        public WrongValueException() { }

        public WrongValueException(string message) : base(message) { }

        public WrongValueException(string message, Exception inner) : base(message, inner) { }
    }
}

using System;

namespace Prymachenko.Exceptions
{
    public class IncorrectEmailExc : Exception
    {
        public IncorrectEmailExc(string email) : base(message: $"Incorrect email: {email}")
        {
        }
    }
}
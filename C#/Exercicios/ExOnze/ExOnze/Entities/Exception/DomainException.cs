using System;

namespace ExOnze.Entities.Exception
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
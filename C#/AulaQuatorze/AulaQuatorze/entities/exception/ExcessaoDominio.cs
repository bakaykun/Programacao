using System;

namespace AulaQuatorze.entities.exception
{
    public class ExcessaoDominio : ApplicationException
    {
        public ExcessaoDominio(string message) 
            : base(message)
        {
        }
    }
}
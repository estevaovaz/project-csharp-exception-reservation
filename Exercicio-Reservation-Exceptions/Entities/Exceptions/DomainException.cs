using System;


namespace Exercicio_Reservation_Exceptions.Entities.Exceptions
{
   public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}

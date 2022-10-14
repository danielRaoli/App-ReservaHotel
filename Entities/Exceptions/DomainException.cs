using System;

namespace Curso7.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message): base(message)
        {

        }
    }
}

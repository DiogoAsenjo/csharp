using System;

namespace PrimeiroProjeto
{
    class DomainException : ApplicationException
    {
       public DomainException(string message) : base(message)
       {
        
       }
    }
}
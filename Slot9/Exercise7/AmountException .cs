using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slot9.obj
{
   public class AmountException : Exception
{
    public string PersonName { get; private set; }

    public AmountException(string message, string personName) : base(message)
    {
        PersonName = personName;
    }
}
}
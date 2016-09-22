using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    /// <summary>
    /// This class allows us to throw exceptions that derive from the same place - this allows us to catch and throw accurate errors and tells us where they come from. Probably shouldn't call this directly. 
    /// </summary>
    public class AdventureException : Exception
    {
        //TODO: define inheritors
    }

    // TODO: create general exceptions
}

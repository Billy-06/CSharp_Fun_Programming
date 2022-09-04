using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fun_Programming
{
    /**
     * We can use Generic Types to create a mapper object.
     * This mapper would need two types specified to it, the first being
     * the source of the object of interest and the second being the type
     * we'd like to map it to
     * 
     * Using a generic types for this sort of task frees the program up of 
     * compatibility constraints providing us with ample flexibility in the
     * program
     * 
     * */
    public interface IMapper<S, T>
    {
        T Map(S source);
    }
}

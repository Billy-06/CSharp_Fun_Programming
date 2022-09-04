﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fun_Programming
{
    public interface IMapper<S, T>
    {
        T Map(S source);
    }
}

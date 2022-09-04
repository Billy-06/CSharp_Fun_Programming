﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fun_Programming
{
    public class CustomerToPersonMapper : IMapper<Customer ,Person>
    {
        public Person Map(Customer source)
        {
            return new Person
            {
                Id = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName,

            };
        }
    }
}

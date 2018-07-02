using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practice_Collections_and_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<stats> players = new List<stats>
            {
                new stats("Kevin Durant", 26.4, 6.8, 5.4),
                new stats("James Harden", 30.4, 5.4, 8.8),
                new stats("Greg Monroe", 10.2, 6.3, 2.3),
                new stats("Andre Drummond", 15.0, 16.0, 3.0),
                new stats("Rajon Rondo", 8.3, 4.0, 8.2)
            };
        }
    }
}

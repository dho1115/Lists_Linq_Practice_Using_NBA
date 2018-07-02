using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Collections_and_Linq
{
    class stats
    {
        public string player { get; set; }
        public double points { get; set; }
        public double rebounds { get; set; }
        public double assists { get; set; }

        public stats()
        {

        } 

        public stats(string play="", double pts = 0, double reb = 0, double asst = 0)
        {
            player = play;
            points = pts;
            rebounds = reb;
            assists = asst;
        }
    }
}

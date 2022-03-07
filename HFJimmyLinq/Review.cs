using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFJimmyLinq
{
    enum Critics
    {
        MuddyCritic,
        RottenTornadoes,
    }
    enum PriceRange
    {
        Cheap,
        Expensive,

    }

    internal class Review
    {
        public int Issue { get; set; }
        public Critics Critic { get; set; }
        public double Score { get; set; }
    }
}

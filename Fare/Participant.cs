using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare
{
    class Participant
    {
        public const double Speed = 160;

        virtual public string Effect()
        {
            string ProblemWithTheBody;

            if (Speed <= 180)

            {
                ProblemWithTheBody = "Everything is not good ";
            }
            return ProblemWithTheBody;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare
{
    class Driver :Participant
    {

        public string Checking { get; set; }
        public Driver(string checking)
        {
            Checking = checking;
        }

        public Driver(Passengers[] whatAreTheyDoing)

        {
            this.whatAreTheyDoing = whatAreTheyDoing;

        }
        private Passengers[] whatAreTheyDoing;


        public string whatAreTheyDoingNow()
        {

            string WhatNow = "";

            for (int i = 0; i < whatAreTheyDoing.Length; i++)
            {


                if (whatAreTheyDoing[i].Activity == Checking)
                    return whatAreTheyDoing[i].Solution;
            }
            return WhatNow;

        }
        public bool turnOffTheRadio()
        {
            bool turOff = false;
            if (Checking == "sing")

                return true;


            return turOff;

        }
        public override string Effect()
        {
            string ProblemWithTheBody = base.Effect();

            return ProblemWithTheBody + "I think I have to slow down";
        }


    }

}

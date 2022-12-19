using System;

namespace Heranca
{
    public class Windows : SO
    {

        
        public Windows(string creator) {
            isOpenSource = false;
            Creator = creator;
        }

        public override string ToString()
        {
            return "Creator: " + Creator
            + ", "
            + "Is Open-Source?: " + isOpenSource;

        }
    }
}

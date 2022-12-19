using System;

namespace Heranca
{
    public class Linux : SO
    {

        
        public Linux(string creator) {
            isOpenSource = true;
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

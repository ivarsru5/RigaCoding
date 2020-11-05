using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day8
{
    class Task1
    {
        private static int[] correctArray;
        
        public static int[] GetOnlySmallValue(int[] userArray)
        {
            int[] correctArray;
            foreach (int element in userArray)
            {
                if (element < 5)
                {
                    correctArray = new int[] { element };
                }
            }
            return correctArray;
        }
    }
}

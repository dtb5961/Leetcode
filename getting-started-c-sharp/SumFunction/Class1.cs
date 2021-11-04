using System;

namespace UtilityLibraries
{
    public class Math
    {
        public static int Sum(int val1, int val2){
            return (val1+ val2);
        }

        public static String sumAsString(int val1, int val2){
            return Sum(val1,val2).ToString();
        }
    }
}

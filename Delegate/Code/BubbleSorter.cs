using System;

namespace Delegate.Code
{
    public delegate bool CompareOp(object lhs, Object rhs);

    public static class BubbleSorter
    {
        static public void Sort(object[] sortArray, CompareOp gtMethod)
        {
            for (int i = 0; i < sortArray.Length; i++)
            {
                for (int j = 0; j < sortArray.Length; j++)
                {
                    if (gtMethod(sortArray[j], sortArray[i]))
                    {
                        var temp = sortArray[i];
                        sortArray[i] = sortArray[j];
                        sortArray[j] = temp;
                    }
                }
            }
        }
        
    }
}
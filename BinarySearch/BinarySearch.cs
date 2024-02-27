namespace ConsoleApp1;
public static class BinarySearch
{
    public static int BinarySearchMethod(int[] search , int num) 
    {
        int start = 0;
        int end = search.Length - 1;
        int midPoint = 0;

        while (start < end)
        {
            midPoint = (start + end) / 2;
            if (midPoint == num)
                return num; 
            else if (midPoint > num)
                end = midPoint;   
            else start = midPoint;
        }
        return -1; 
    }

}

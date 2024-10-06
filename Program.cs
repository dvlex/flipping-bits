// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;

Console.WriteLine("Hello, World!");

long number = 1;

Console.WriteLine(Result.flippingBits(number));


class Result
{

    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        string stringResult = Convert.ToString(n,2).PadLeft(32, '0');
        string temp = stringResult.Replace('0', '#');
        temp = temp.Replace('1', '0');
        stringResult = temp.Replace('#','1');
        return Convert.ToInt64(stringResult, 2);
    }

}
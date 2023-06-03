using System;
public class HW_3_task2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int N = Convert.ToInt32(Console.ReadLine());
        double[] result_array = new double[N];
        for (int i=1; i<=N; i++)
        {
            result_array[i-1] = Math.Pow(i, 3);
        }
        //Console.WriteLine("Enter point B coordinates:");
        //int[] B = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

        //double C = Math.Sqrt(Math.Pow((B[0]-A[0]), 2) + Math.Pow((B[1]-A[1]), 2) + Math.Pow((B[2]-A[2]), 2));
        //Console.WriteLine(result_array);
        Console.WriteLine(string.Join(", ", result_array));
    }
}
using System;

namespace Test_5_PolesUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 1, 2,8,2,4,3,1 }; // масив целых чисел
            int max = nums[0]; // максимальное число
            int j = 0; // индекс максимума
            for(int i = 0; i<nums.Length;i++)
            {
                if(max<=nums[i])
                {
                    max = nums[i];
                    j = i;
                }
            }
            Console.WriteLine($"Максимальное число: {max}, С индексом: {j}");
        }
    }
}

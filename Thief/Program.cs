using System;

namespace Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thief th = new Thief();
            Console.WriteLine(th.Rob(new int[] { 1, 2, 3, 4, 5, 6 ,7}));
            Console.WriteLine(th.Rob(new int[] { 1, 2, 3, 1 }));
            Console.WriteLine(th.Rob(new int[] { 2, 7, 9, 3, 1 }));
            Console.ReadLine();
        }

        public class Thief
        {
            public int Rob(int[] nums)
            {
                int sumOddNumbers = 0;
                int sumEvenNumbers = 0;

                for (int i = 0; i < nums.Length; i += 2)
                    sumEvenNumbers += nums[i];

                for (int i = 1; i < nums.Length; i += 2)
                    sumOddNumbers += nums[i];

                return sumEvenNumbers > sumOddNumbers ? sumEvenNumbers : sumOddNumbers;
            }
        }
    }
}

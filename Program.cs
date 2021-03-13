using System;

namespace EuclideanAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int ABig, BSmall;
            Console.Write("Number1:");
            ABig = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number2:");
            BSmall = Convert.ToInt32(Console.ReadLine());

            if(ABig<BSmall)
            {
                int tmp = ABig;
                ABig = BSmall;
                BSmall = tmp;
            }

            int output=Process(ABig, BSmall);
            Console.WriteLine($"Greatest Common Division: {output}");
        }

        static int Process(int big,int small)
        {
            int modNum = big % small;
            if (modNum == 0)
            {
                return small;
            }
            else
            {
                big = small;
                small = modNum;
                return Process(big, small);
            }
        }
    }
}

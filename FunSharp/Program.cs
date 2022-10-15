using System;
//solution([-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
// returns "-10--8,-6,-3-1,3-5,7-11,14,15,17-20"
namespace FunSharp
{
    class Program
    {
        static string RangeExtraction(int[] args)
        {
            string output = "";

            int[] copyArgs = new int[args.Length];
            args.CopyTo(copyArgs, 0);

            for (int i = 0; i < copyArgs.Length; i++)
            {
                if(copyArgs[i] < 0)
                    copyArgs[i] += -i;
                else if (copyArgs[i] >= 0)
                    copyArgs[i] -= i;
            }

            for (int i = copyArgs[0], k = 0; i <= copyArgs[copyArgs.Length-1]; i++, k++)
            {
                if (i != copyArgs[k])
                {
                    k--;
                    continue;
                }

                int initial = Math.Abs(Array.IndexOf(copyArgs, i));
                int final = Math.Abs(Array.LastIndexOf(copyArgs, i));

                if (final - initial < 2)
                {
                    output += args[initial] + ",";
                    if(final > initial)
                        output += args[final] + ",";

                    k = Math.Abs(final);
                }
                else if (final - initial >= 2)
                {
                    output += args[initial] + "-" + args[final] + ",";
                    k = Math.Abs(final);
                }
            }

            return output.TrimEnd(',');
        }
        static void Main()
        {
            int[] array = new int[] {-6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20};
            Console.WriteLine(RangeExtraction(args: array));
        }
    }
}
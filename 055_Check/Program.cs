using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = 0, b = 0, sum = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}: 다음 두 수의 합은 몇?(총 5문제)",i);
                a = rnd.Next(1, 100);
                b = rnd.Next(1, 100);
                sum = a + b;
                Console.Write("{0} + {1} = ",a,b);
                int ans = int.Parse(Console.ReadLine());
                if (ans == sum)
                {
                    Console.WriteLine("== 정답 ==");
                }
                else
                {
                    Console.WriteLine("오답(정답은: {0})", sum);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
            int cnt = 0;

            for(; ; )
            {
                cnt++;
                Console.WriteLine("0 ~ 99 사이 어떤 숫자일까요(단, 0은 나가기)");
                int ans = int.Parse(Console.ReadLine());

                if (ans == 0)
                {
                    break;
                }
                if (ans > num)
                {
                    Console.WriteLine("입력한 수는 커요");
                }
                else if(ans < num)
                {
                    Console.WriteLine("입력한 수는 작아요");
                }
                else
                {
                    Console.WriteLine("=== 정답 입니다. ===");
                    Console.WriteLine("총 {0}번 시도", cnt);
                    break;
                }
            }
        }
    }
}

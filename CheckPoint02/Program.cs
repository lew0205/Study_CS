using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckPoint02
{
    class Program
    {
        const string LINE = "-------------------------------------------";
        const int END_LINE = 42;

        static int runA = 0;
        static int runB = 0;
        static int runC = 0;
        static int runD = 0;

        static void ClearScreen()
        {
            Thread.Sleep(1000);
            Console.Clear();
        }

        static void Process(Random rnd)
        {
            runA++;
            runB++;
            runC++;
            runD++;

            int rndNum = rnd.Next(1, 5);
            int rndRunNum = rnd.Next(1, 5);

            switch (rndNum)
            {
                case 1:
                    runA += rndRunNum;
                    break;
                case 2:
                    runB += rndRunNum;
                    break;
                case 3:
                    runC += rndRunNum;
                    break;
                case 4:
                    runD += rndRunNum;
                    break;
            }
        }

        static void UpdateScreen()
        {
            Console.WriteLine(LINE);

            for (int i = 0; i < runA; i++)
                Console.Write(" ");
            Console.WriteLine("1");

            for (int i = 0; i < runB; i++)
                Console.Write(" ");
            Console.WriteLine("2");

            for (int i = 0; i < runC; i++)
                Console.Write(" ");
            Console.WriteLine("3");

            for (int i = 0; i < runD; i++)
                Console.Write(" ");
            Console.WriteLine("4");
            Console.WriteLine(LINE);

        }

        static bool CheckResult()
        {
            if (runA >= END_LINE || runB >= END_LINE || runC >= END_LINE || runD >= END_LINE)
            {
                string strResult = "결과: ";

                if (runA >= END_LINE)
                {
                    strResult += "1";
                }

                else if (runB >= END_LINE)
                {
                    strResult += "2";
                }

                else if (runC >= END_LINE)
                {
                    strResult += "3";
                }

                else
                {
                    strResult += "4";
                }

                Console.WriteLine(strResult);
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            while (true)
            {
                ClearScreen();

                Process(rnd);

                UpdateScreen();

                if (CheckResult() == false)
                    break;
            }
        }

    }
}

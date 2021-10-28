using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("국어 점수 입력하세요: ");
            int kor = int.Parse(Console.ReadLine());

            Console.Write("수학 점수 입력하세요: ");
            int mat = int.Parse(Console.ReadLine());

            Console.Write("사회 점수 입력하세요: ");
            int soc = int.Parse(Console.ReadLine());

            Console.Write("과학 점수 입력하세요: ");
            int sci = int.Parse(Console.ReadLine());

            int sum = kor + mat + soc + sci;
            float avr = sum / 4f;

            Console.WriteLine("국어: {0}\t영어: {1}\t수학: {2}\t과학: {3}\n총점: {4}\t평균: {5}", kor, mat, soc, sci,sum,avr);
        }
    }
}

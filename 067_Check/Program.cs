﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _067_Check
{
    class Program
    {
        static void Start()
        {
            Console.WriteLine("성적 프로그램 - Method");
        }

        static void Input(ref int kor, ref int mat, ref int eng)
        {
            Console.Write("국어 성적 입력(정수)? ");
            kor = int.Parse(Console.ReadLine());
            Console.Write("수학 성적 입력(정수)? ");
            mat = int.Parse(Console.ReadLine());
            Console.Write("국어 성적 입력(정수)? ");
            eng = int.Parse(Console.ReadLine());
        }

        static int Total(int kor,int mat,int eng)
        {
            return (kor + mat + eng);
        }

        //static void Average(int total, out float average)
       // {

        //}

        static void Main(string[] args)
        {
            int kor = 0;
            int eng = 0;
            int mat = 0;
            int total;
            float average;

            
        }
    }
}

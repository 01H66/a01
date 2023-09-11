using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Linq的基本使用
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string email = "zhangsan@11.com";
            Console.WriteLine(email.ValidateEmail(""));

            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr.Average());

            double[] arr2 = { 1.2, 1.3, 4.1, 4.5 };
            Console.WriteLine(arr2.Average());
            Console.ReadLine();
        }
    }
}
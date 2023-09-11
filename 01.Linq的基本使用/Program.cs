//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _01.Linq的基本使用
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            //1.使用Linq遍历数组
//            int[] scores = new int[] { 97, 92, 81, 60 };
//            List<int> list = new List<int>();
//            IEnumerable<int> result = list.Where(s => s > 80);

//            //2.使用Linq遍历dataTable
//            DataTable dataTable = new DataTable();
//            dataTable.Columns.Add("score");
//            DataRow row1 = dataTable.NewRow();
//            row1["score"] = 80;
//            DataRow row2 = dataTable.NewRow();
//            row2["score"] = 90;
//            DataRow row3 = dataTable.NewRow();
//            row3["score"] = 70;
//            dataTable.Rows.Add(row1);
//            dataTable.Rows.Add(row2);
//            dataTable.Rows.Add(row3);

//            IEnumerable<DataRow> rows = dataTable.AsEnumerable();
//            IEnumerable<DataRow> result2 = rows.Where(row => Convert.ToInt32(row["score"]) > 80);
//            Console.WriteLine(result2);

//            Console.ReadLine();
//        }
//    }
//}
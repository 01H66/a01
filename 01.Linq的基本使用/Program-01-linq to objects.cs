//using System;
//using System.Collections;
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
//            List<Student> students = new List<Student>();
//            students.Add(new Student()
//            {
//                Id = 1,
//                Name = "zhangsan",
//                Age = 20,
//                Sex = "男"
//            });
//            students.Add(new Student()
//            {
//                Id = 2,
//                Name = "lisi",
//                Sex = "男",
//                Age = 30
//            });
//            students.Add(new Student()
//            {
//                Id = 3,
//                Name = "王五",
//                Age = 40,
//                Sex = "女"
//            });
//            students.Add(new Student()
//            {
//                Id = 4,
//                Name = "赵六",
//                Age = 22,
//                Sex = "女"
//            });
//            students.Add(new Student()
//            {
//                Id = 5,
//                Name = "朱琦",
//                Age = 22,
//                Sex = "女"
//            });

//            //1. Select方法可以查询指定数据源中的部分信息
//            IEnumerable<string> names = students.Select(s => s.Name);
//            IEnumerable<object> nameAndAges = students.Select(s => new { Name = s.Name, Age = s.Age });
//            IEnumerable<int> ages = students.Select(s => s.Age * 2);

//            //Func<string, string> fun1 = s => {
//            //    Console.WriteLine("");
//            //    return s + "aa";
//            //};

//            //2. Where方法：从数据源中根据指定条件过滤出我们想要的数据
//            IEnumerable<Student> stus = students.Where(s => s.Age > 30);
//            IEnumerable<Student> stus2 = students.Where(s => s.Age > 30 || s.Id == 2);
//            IEnumerable<string> names2 = students.Where(s => s.Sex == "男").Select(s => s.Name);
//            IEnumerable<Student> stus3 = students.Where(s => s.Name.Substring(0, 1) == "z");

//            //3.Any 和 All方法:
//            //students.Any(s => s.Age > 20) ： 只要学生集合中有任何一个学生的年龄大于20，整个表达式的返回值就是true
//            //students.All(s => s.Age > 20) :  当students集合中的所有学生年龄都大于20，整个表达式的结果才是true；有任何一个不满足条件，则返回false
//            bool flag = students.Any(s => s.Age > 20);
//            bool flag2 = students.All(s => s.Age > 20);

//            //4.Take和Skip:
//            //Take(2) : 从数据源中按照顺序获取两个数据
//            //Skip(1) : 表示跳过数据源的前1条数据，获取后面所有数据
//            //Skip(1).Take(2) : 表示跳过前面1条数据，获取两条数据
//            IEnumerable<Student> stus4 = students.Skip(1).Take(2);

//            //5.First 和 FirstOrDefault
//            //First() ：返回数据源中的第一个元素(如果集合为空或报错)
//            //FirstOrDefault() :返回数据源中的第一个元素，如果集合中没有元素返回null (推荐使用报错)
//            Student stu = students.First();
//            Student stu2 = students.FirstOrDefault();

//            //6.Count Max Min Average
//            int count = students.Count();
//            int maxAge = students.Max(s => s.Age);
//            int minAge = students.Min(s => s.Age);
//            int maxAge2 = students.Select(s => s.Age).Max();
//            double avgAge = students.Average(s => s.Age);

//            //7.排序
//            IEnumerable<Student> stus5 = students.OrderBy(s => s.Age);
//            IEnumerable<Student> stus6 = students.OrderByDescending(s => s.Age);
//            IEnumerable<Student> stus7 = students.OrderBy(s => s.Age).ThenBy(s => s.Id);
//            IEnumerable<Student> stus8 = students.OrderBy(s => s.Age).ThenByDescending(s => s.Id);

//            //8.分组
//            IEnumerable<IGrouping<string, Student>> groups = students.GroupBy(s => s.Sex);
//            foreach (IGrouping<string, Student> group in groups)
//            {
//                Console.WriteLine($"{group.Key}");
//                //foreach (Student tmp in group) {
//                //    Console.WriteLine($"{tmp.Id}---{tmp.Name}---{tmp.Age}");
//                //}
//                var names3 = group.Select(s => s.Name);
//                Console.WriteLine(names3);
//            }

//            //按照性别来分组，求组的个数
//            int groupCount = students.GroupBy(s => s.Sex).Count();

//            //按照性别来分组，求每组的人数
//            IEnumerable<IGrouping<string, Student>> groups2 = students.GroupBy(s => s.Sex);
//            foreach (IGrouping<string, Student> tmp in groups2)
//            {
//                Console.WriteLine($"{tmp.Key}---{tmp.Count()}");
//            }
//            Console.ReadLine();
//        }
//    }
//}}
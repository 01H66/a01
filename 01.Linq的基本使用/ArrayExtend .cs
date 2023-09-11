using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Linq的基本使用
{
    //1. 扩展方法所在的类必须声明为static。
    //2. 扩展方法必须声明为public和static。
    //3. 扩展方法的第一个参数必须包含关键字this，并且在后面指定扩展的类的名称。
    //4. 只有实现了IEnumerable接口的类型才能添加扩展方法。

    public static class ArrayExtend
    {
        public static double Average<T>(this T[] array) where T : struct
        {
            double sum = 0;
            foreach (T item in array)
            {
                sum += Convert.ToDouble(item);
            }
            return sum / array.Length;
        }
    }
}
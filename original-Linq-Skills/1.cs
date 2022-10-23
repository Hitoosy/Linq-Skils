
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Skills
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TestResult> results = new List<TestResult>()
            {
                new TestResult(){Name = "Suzuki Ichiro", Math = 80, Physics = 60},
                new TestResult(){Name = "Akagawa Jiro", Math = 70, Physics = 90},
                new TestResult(){Name = "Mikawa Saburo", Math = 90, Physics = 100},
            };

            //double mathAve = results.CalcAverage(tr => tr.Math);
            //double phsycsAve = results.CalcAverage(tr => tr.Physics);

            //Console.WriteLine(mathAve);
            //Console.WriteLine(phsycsAve);

            //Linqが強力な理由
            double mathAveLINQ = results.Average(tr => tr.Math);
            Console.WriteLine(mathAveLINQ);
        }
    }
}

/*
public static class ListUtil
{
    public static double CalcAverage<T>(this List<T> results, Func<T, double> func)
    {
        double ans = 0;
        foreach(T tr in results)
        {
            ans += func(tr);
        }
        ans /= results.Count;
        return ans;
    }
}
*/

public class TestResult
{
    public string Name { get; set; }

    public double Math { get; set; }

    public double Physics { get; set; }
}


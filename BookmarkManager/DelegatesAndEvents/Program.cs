using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        private static List<int> _Ages;

        delegate List<int> SortAges(List<int> ages);
        static void Main(string[] args)
        {
            _Ages = new List<int>();
            _Ages.Add(5);
            _Ages.Add(1);
            Sort(_Ages, SortAsc);
            foreach (int age in _Ages)
            {
                Console.WriteLine(age);
            }
            Sort(_Ages, SortDesc);
            foreach (int age in _Ages)
            {
                Console.WriteLine(age);
            }
            Console.Read();
        }

        private static List<int> Sort(List<int> ages, SortAges f)
        {
            return f.Invoke(ages);
        }

        private static List<int> SortAsc(List<int> ages)
        {
            ages.Sort();
            return ages;
        }

        private static List<int> SortDesc(List<int> ages)
        {
            //IComparer<int> descComparer = new DescComparer();
            ages.Sort();
            ages.Reverse();
            return ages;
        }

        //IComparer<T> comparer
                
        
        //delegate [return type] [delegate name] ([parameter types and names])







        //[Flags]
        //enum MyEnum
        //{
        //    None = 0,
        //    One = 0x1,
        //    Two = 0x2,
        //    Four = 0x4,
        //    Eight = 0x8
        //}
    }
}

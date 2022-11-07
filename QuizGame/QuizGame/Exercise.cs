using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    internal class Exercise
    {

        void TestOne()
        {
               var numbers = new List<int>() { 78, 43, 12, 893, 19, 4, 563, 81, 12, 521, 5, 29 };
                numbers.Add(3678);
            //var selected = numbers.Where(n => n >= 50);
            //foreach (var item in selected)
            //{
            //    Console.WriteLine(item);
            //}

            var oneElement = numbers.FirstOrDefault(n => n > 100000000);
                Console.WriteLine(oneElement);

            var ordered = numbers.OrderByDescending(n => n);

            foreach (var item in ordered)
            {
                Console.WriteLine(item);
            }

            var sum = numbers.Sum();
            Console.WriteLine(sum);
        }

        void Test()
        {
            //var list = new List<string>();
            //list.Add("Ania");
            //list.Add("Victoria");
            //list.Add("Andrew");
            //var name = list[1];
            //var howMany = list.Count;

            //int x;
            //string y;

            //bool z;


            //for (int index = 0; index < 1000000; index++)
            //    Console.WriteLine(index);


            //var names = new List<string>();
            //names.Add("Zosia");
            //names.Add("Tomek");
            //names.Add("Viktoria");
            //names.Add("Anna");
            //names.Add("Taras");
            //names.Add("Jan");

            //foreach (var n in names)
            //    Console.WriteLine(n);

            //var x = 3; // operator przypisania
            //var y = x / 3;
            //var z = x * 7;
            //var k = x - 4;
            //var p = x % 2;

            //if (x == 4 && x == 5) // operator porównania
            //{

            //}

            //if (x != 4)
            //{
            //    Console.WriteLine("PRAWDA");
            //}

            //if (x != 3)
            //{
            //    Console.WriteLine("PRAWDA");
            //}
            //else
            //{
            //    Console.WriteLine("FAŁSZ");
            //}

        }

       
    }
}

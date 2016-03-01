using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var peopleList = new People[7];

            int massivePosotion = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Your can create seven person");
                Console.WriteLine("Do you want create people? Print Y if you want ");
                var answer = Console.ReadLine();

                if (answer != "y")
                {
                    break;
                }

                Console.WriteLine("Write name");
                var name = Console.ReadLine();

                Console.WriteLine("Write age");
                var age = Convert.ToInt32(Console.ReadLine());

                if (age > 100 && age < 0)
                {
                    Console.WriteLine("No valid age");
                    continue;
                }

                Console.WriteLine("Choose gender 0 - male, 1 - feemale");
                var gender = Console.ReadLine();
                Gender genderType;

                switch (gender)
                {
                    case "1":
                        genderType = Gender.Female;
                        break;
                    case "2":
                        genderType = Gender.Male;
                        break;
                    default:
                        Console.WriteLine("Unknown gender type");
                        continue;
                }

                var person = new People(age, name, genderType);
                peopleList[massivePosotion] = person;

                massivePosotion++;
                if (massivePosotion > 6)
                {
                    Console.WriteLine("Massive is full");
                    break;
                    ;
                }
            }

            //SortByAge(peopleList);

            foreach (var people in peopleList)
            {
                if (people != null)
                {
                    people.GetInfo();
                }
            }

            Console.ReadKey();
        }

        private static void SortByAge1(People[] peopls1)
        {
            int length = peopls1.Length;
            for (int i = 0; i < peopls1.Length; i++)
            {
                if (peopls1[i] == null)
                {
                    length = i;
                    break;
                }
            }
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (peopls1[i].Age > peopls1[j].Age)
                    {
                        var tempPeople = peopls1[j];
                        peopls1[j] = peopls1[i];
                        peopls1[i] = tempPeople;
                    }
                }
            }

        }

        private static void SortByName1(People[] peopls1)
        {
            string[] array = People[];
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < array.Length - 1; ++i)
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        string buf = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = buf;
                        flag = true;
                    }
            }
            foreach (string s in array)
                Console.WriteLine("{0} ", s);
        }
    }
}

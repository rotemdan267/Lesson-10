using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            MethodWithOut(out myInt);
            MethodWithRef(ref myInt);

            Console.WriteLine(BuildSentence("meir", "went", "to", "get", "bread"));

            Person p1 = new Person()
            {
                age = 3,
                name = "asd"
            };
            Person p2= new Person()
            {
                age = 676,
                name = "zxc"
            };
            Person p3 = new Person()
            {
                age = 355,
                name = "qwe"
            };
            Person p4 = new Person()
            {
                age = 36,
                name = "bvc"
            };
            Person p5 = new Person()
            {
                age = 8,
                name = "hgf"
            };
            PrintNameAndIncreaseAge(p1, p2, p3, p4, p5);

            Console.ReadLine();
        }
        static void PrintNameAndIncreaseAge(params Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].name);
                Console.WriteLine(people[i].age);
                people[i].IncreaseAge(people[i]);
                Console.WriteLine(people[i].age);
                Console.WriteLine();
            }
        }
        static string BuildSentence(params string[] sentence)
        {
            string sent;
            sent = string.Join(" ", sentence);
            return sent;
        }
        static void MethodWithOut(out int num)
        {
            num = 0;
        }
        static void MethodWithRef(ref int num)
        { 
        }
    }
    class Person
    {
        public string name;
        public int age;

        public void IncreaseAge(in Person p)
        {
            p.age++;
        }
    }
}

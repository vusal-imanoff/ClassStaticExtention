using System;
using StaticKeywordExtention.Extention;
using StaticKeywordExtention.Class;

namespace StaticKeywordExtention
   
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task-1
            Console.WriteLine("Enter your GroupNo: ");
            string groupno = Console.ReadLine();
            Console.WriteLine("Enter your Fullname: ");
            string fullname = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age;
            int.TryParse(Console.ReadLine(), out age);

            Student.Fullname = fullname;
            Student.GroupNo = groupno;
            Student.Age = age;
            Student.Info();

            #endregion

            #region Task-2
            //Console.WriteLine("Enter number: ");
            //int number;
            //int.TryParse(Console.ReadLine(), out number);
            //Console.WriteLine(number.IsEven());

            //Console.WriteLine("Enter word: ");
            //string word = Console.ReadLine();
            //Console.WriteLine("Enter symbol: ");
            //char temp;
            //char.TryParse(Console.ReadLine(), out temp);

            //int[] arr = word.GetValueIndexes(temp);
            //foreach (int item in arr)
            //{
            //    Console.Write($"Index- {item}\n");
            //}
            #endregion



        }
    }
}

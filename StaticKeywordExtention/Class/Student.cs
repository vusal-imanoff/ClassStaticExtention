using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeywordExtention.Class
{
    class Student
    {
        static string _groupNo;
        static string _fullName;
        static int _age;

        public Student(string no, string fullname, int age)
        {
            GroupNo = no; ;
            Fullname = fullname;
            Age = age;
        }

        public static int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public static string Fullname
        {
            get
            {
                return _fullName;
            }
            set
            {
                while (!CheckFullName(value))
                {
                    Console.WriteLine("Pleaase enter correct fullname");
                    value = Console.ReadLine();
                }
                _fullName = value;

            }
        }
        public static bool CheckGroupno(string groupno)
        {
            if (groupno.Length == 4)
            {
                int saygac = 0;
                for (int i = 0; i < groupno.Length; i++)
                {
                    if (char.IsUpper(groupno[i]) && i==0)
                    {
                        saygac++;
                    }

                    else if (char.IsDigit(groupno[i]))
                    {
                        saygac++;
                    }
                }
                if (saygac == 4)
                {
                    return true;

                }
                return false;
            }
            return false;
        }
        public static string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                while (!CheckGroupno(value))
                {
                    Console.WriteLine("Please enter corret GroupNo");
                    value = Console.ReadLine();
                }
                _groupNo = value;
            }
        }

        public static bool CheckFullName(string fullname)
        {
            int saygac=0;
            for (int i = 0; i < fullname.Length; i++)
            {
                if (char.IsUpper(fullname[i]) && i == 0)
                {
                    saygac++;
                }
                else if (char.IsWhiteSpace(fullname[i]))
                {
                    saygac++;
                    if (char.IsUpper(fullname[i + 1]))
                {
                    saygac++;
                }
                }
                 
            }
            if(saygac==3)
            {
                return true;
            }
            return false;

        }

        public static void Info()
        {
            Console.WriteLine($" Group-{_groupNo}\n Fullname- {_fullName }\n Age- {_age}");
        }
    }
}

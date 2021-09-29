using System;
using System.Collections.Generic;
namespace Exercise_4
{
    class Program
    {
        class Students
        {
            public int IDstudent { set; get ; }
            public string Name { set; get; }

        }
        static void Main(string[] args)
        {
            List<Students> Student = new List<Students>()
            {
                new Students()
                {

                   Name ="Luu Nguyen Quoc Bao",IDstudent =1911061558
                },
                new Students()
                {

                   Name ="Bui Nguyen Thien An",IDstudent = 1911061448
                },
                new Students()
                {

                   Name ="Nguyen Xuan Thien Phu",IDstudent = 1911061235
                },
                new Students()
                {

                   Name ="Tran The Anh",IDstudent = 1911061564
                },
                new Students()
                {

                   Name ="Nguyen Bach Thang",IDstudent = 1911061235
                },
                new Students()
                {

                   Name ="Phan Le Quang Nhan",IDstudent = 1911061456
                }
            };
            
            foreach( var s in Student)
            {
                Console.WriteLine($"{s.Name} - {s.IDstudent}");
            }

            Student.Sort(delegate (Students s1, Students s2)
           {
               if (s1.IDstudent == s2.IDstudent) return 0;
               else if (s1.IDstudent < s2.IDstudent) return 1;
               else if (s1.IDstudent > s2.IDstudent) return -1;
               else return s1.IDstudent.CompareTo(s2.IDstudent);
           });
            
            Console.WriteLine("\nAfter sort by IDstudent:");
            foreach (var s in Student)
            {
                Console.WriteLine($"{s.Name} - {s.IDstudent}");
            }
            
            Student.Sort(delegate (Students x, Students y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Name.CompareTo(y.Name);
            });

            Console.WriteLine("\nAfter sort by name:");
            foreach (Students s in Student)
            {
                Console.WriteLine($"{s.Name} - {s.IDstudent}");
            }
        }


        
        }
                

}
        

 


using System;

namespace final2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pointnumber = int.Parse(Console.ReadLine());
            node node1 = new node();
            node store = new node();
            instructor instructorlist;
            instructor storelist;
            int checkconditionA = 0, checkconditionB = 0, checkconditionC = 0, checkconditionD = 0, checkconditionE = 0;
            int y = 0;
            string name, checkinputinstructor = "";

            for (int i = 0; i < 5 * pointnumber; i++)
            {
                name = Console.ReadLine();
                instructorlist = new instructor(name);
                node1.Push(instructorlist);
            }

            for (int i = 0; i < 5 * pointnumber; i++)
            {
                checkinputinstructor = node1.Get(0);
                if (checkconditionA < 1 && checkinputinstructor == "A")
                {
                    node1.Pop();
                    checkconditionA++;
                    checkinputinstructor = node1.Get(0);
                }
                else if (checkconditionE >= 1 && checkinputinstructor == "A")
                {
                    node1.Pop();
                    checkconditionA++;
                    checkinputinstructor = node1.Get(0);
                }
                else
                {
                    storelist = new instructor(checkinputinstructor);
                    node1.Pop();
                    store.Push(storelist);
                    y++;
                }
                if (checkconditionA >= 1 && checkinputinstructor == "B")
                {
                    node1.Pop();
                    checkconditionB++;
                    checkinputinstructor = node1.Get(0);
                }
                else
                {
                    storelist = new instructor(checkinputinstructor);
                    node1.Pop();
                    store.Push(storelist);
                    y++;
                }
                if (checkconditionB >= 1 && checkinputinstructor == "C")
                {
                    node1.Pop();
                    checkconditionC++;
                    checkinputinstructor = node1.Get(0);
                }
                else
                {
                    storelist = new instructor(checkinputinstructor);
                    node1.Pop();
                    store.Push(storelist);
                    y++;
                }
                if (checkconditionC >= 1 && checkinputinstructor == "D")
                {
                    node1.Pop();
                    checkconditionD++;
                    checkinputinstructor = node1.Get(0);
                }
                else
                {
                    storelist = new instructor(checkinputinstructor);
                    node1.Pop();
                    store.Push(storelist);
                    y++;
                }
                if (checkconditionD >= 1 && checkinputinstructor == "E")
                {
                    if(checkconditionA!=pointnumber && checkconditionB != pointnumber && checkconditionC != pointnumber && checkconditionD != pointnumber && checkconditionE != pointnumber)
                    {
                        node1.Pop();
                        checkconditionE++;
                        checkinputinstructor = node1.Get(0);
                    }
                    else 
                    {
                        break;
                    }
                }
                else
                {
                    storelist = new instructor(checkinputinstructor);
                    node1.Pop();
                    store.Push(storelist);
                    y++;//บวกไว้เช็คว่ามีตัวที่เข้าไปในคลังกี่ตัว
                }

            }
           
        }

    }
}
     
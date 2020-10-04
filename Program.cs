using System;

namespace oop_6115261020_w06
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Baekhyun", " ", 20000, "Lecturer");
            Person p2 = new Person("Chanyeol", "", 25000, "Lecturer");
            Person p3 = new Person("Kai", "", 30000, "Staff");
            Faculty f1 = new Faculty("Faculty of Educational");
            f1.setPerson(p1, 0);
            f1.setPerson(p2, 1);
            f1.setPerson(p3, 2);
            f1.printAll();
        }
    }
}

using System;

namespace kviddics
{
    class Roxfort
    {
        static void Main(string[] args)
        {
            Student Potter = new Student("Harry", 6);
            Random rnd = new Random();
            Potter.Points = rnd.Next(1, 9999);
            Console.Write("Neve: {0}, Osztály: {1}, Pontszám: {2}", Potter.Name, Potter.Sclass, Potter.Points );
        }
        
    }
    public class Student
    {
        private string name;
        private int sclass;
        private int points;

        public string Name
        {
            get { return name; }
        }
        
        public int Sclass
        {
            get { return sclass; }
        }
        public int Points
        {
            get { return points; }
            set { points = value; }
        }
        public Student(string sname, int cyear)
        {
            name = sname;
            sclass = cyear;
        }

    }
}

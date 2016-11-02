using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLesson1
{
    class Program
    {
        static void Main()
        {

            //Reminder Ctrl F5 will run the program for you and stop at the end.


            //Instantiates the class we created.
            Pen bluePen = new Pen();

            bluePen.Cap = false;
            bluePen.Clip = true;
            bluePen.DateMade = DateTime.Parse("1/1/2015");
            bluePen.InkColor = "Blue";
            bluePen.PenColor = "Silver";
            bluePen.Weight = 1.0M;
            bluePen.IsExtended = false;


            bluePen.togglePoint();


            //Writes information to Console
            Console.WriteLine("Ink Color: " + bluePen.InkColor);
            Console.WriteLine("Pen Color: " + bluePen.PenColor);
            Console.WriteLine("Clip? " + bluePen.Clip);
            Console.WriteLine("Extended? " + bluePen.IsExtended);
            Console.WriteLine("Age: " + bluePen.Age);

        }
    }


    public class Pen
    {

        public string InkColor { get; set; }
        public decimal Weight { get; set; }
        public bool Clip { get; set; }
        public bool Cap { get; set; }
        public string PenColor { get; set; }
        public DateTime DateMade { get; set; }

        private int age;
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;

                int currentAge = now.Year - DateMade.Year;

                age = currentAge;

                return age;

            }
        }


        public bool IsExtended { get; set; }


        public void togglePoint()
        {

            if (IsExtended)
            {
                IsExtended = false;
            }
            else
            {
                IsExtended = true;
            }

        }

    }
}

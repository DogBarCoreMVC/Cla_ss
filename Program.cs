using System;

namespace Cla_ss
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee m1 = new Employee();
            Console.WriteLine("m1.Name = " + m1.Name);
            Console.WriteLine("m1.yearOfBirth = " + m1.YearOfBirth + "\n");

            Employee m2 = new Employee();
            m2.Name = "Sulachai";
            m2.YearOfBirth = 1989;
            Console.WriteLine("m2.Name = " + m2.Name);
            Console.WriteLine("m2.yearOfBirth = " + m2.YearOfBirth + "\n");

            m1.Name = m2.Name;
            Console.WriteLine("m1.Name = " + m1.Name + "\n");//กำหนดค่าให้ m1.name ใหม่ ใฟ้มีค่าเป็น m2.name

            Employee m3 = new Employee("02-554-8795", "Anawut@Local.com");
            Console.WriteLine("m2.Name = " + m2.Name);
            Console.WriteLine("m2.yearOfBirth = " + m2.YearOfBirth);
            Console.WriteLine("telePhoneNumber = " + m3.TelePhoneNumber);
            Console.WriteLine("Mail = " + m3.Mail + "\n");

            /*----------------Evaluation-----------------*/

            Employee m4 = new Employee()
            {
                Name = "Suparne",
                Score = 95.6
            };

            Evaluation evaluation = new Evaluation();
            var no1 = evaluation.CalculateGrade(m4);
            Console.WriteLine("No1. = " + no1 + "\n");

            Employee m5 = new Employee()
            {
                Name = "Onuma",
                DepartMent = "Accounting",
                TelePhoneNumber = "065-885-8745",
                YearOfBirth = 1985,
                Mail = "onuma@Isuzu.com",
                Score = 75
            };

            Evaluation evaluation1 = new Evaluation();
            Console.WriteLine("m5 = " + evaluation1.CalculateGrade(m5));

        }
    }
}

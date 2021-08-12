using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cla_ss
{
    class Employee
    {
        public string Name;
        public int YearOfBirth;

        public string TelePhoneNumber;
        public string Mail;

        public double Score;
        public string DepartMent;


        public Employee()
        //Constructor คือชื่อจะเป็นื่อเดียวกันกับชื่อ Class และจะ retrun ไม่ได้ Contructor มีกี่ตัวก็ได้แต่ต้องมี signature เป็นของตัวเอง ตัวอย่างข้างล่าง
        {
            Name = "Wuttisuk";
            YearOfBirth = 1990;

        }

        public Employee(string telePhoneNumber, string mail)//การใช้งานแบบนี้เรียนกว่า Construtor Overlonding คือต้องผ่านค่าเข้าไปใน parameter ไม่ให้ไปซ้ำกับ Conttrutor ตัวอื่น
        {
            TelePhoneNumber = telePhoneNumber;
            Mail = mail;
        }

        public Employee(double score, string dePartMent)
        {
            Score = score;
            DepartMent = dePartMent;
        }
    }
}

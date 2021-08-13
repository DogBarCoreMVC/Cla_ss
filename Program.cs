using System;

namespace Cla_ss
{
    class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Employee()//ประกาศ object m1
            {
                EmployeeCode = "1145223658",//กำหนดค่าให้
                Score = 75.69//กำหนดค่าให้
            };

            var m2 = new Employee()//ประกาศ object m2
            {
                EmployeeCode = "5514223650",//กำหนดค่าให้
                Score = 59.25//กำหนดค่าให้
            };

            var employees = new Employee[2]//สร้าง array มาใช้งาน จองพื้นที่ไว้ 2 index(2 ช่อง)
            {
                m1,m2//เก็บค่าจาก object m1,m2
            };

            Evaluation evaluation = new Evaluation();
            //ประกาศ object evaluation และให้เข้าไปในทำงาน method Evaluation
            evaluation.CalculetGrade(employees);
            //ใช้งาน object evaluation และช้งาน method CalculetGrade แล้วผ่านค่าเข้า parameter เป็นค่า object evaluation มี DataType เป็น array

        }
    }
}

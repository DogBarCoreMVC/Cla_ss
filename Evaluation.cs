using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cla_ss
{
    class Evaluation
    {
        public void CalculetGrade(Employee[] employees)//ผ่่านค่าเข้า parameter เป็นค่า array จาก ocject employees
        {
            for (int i = 0; i < employees.Length; i++)//ทำการ loop ค่าจาก ocject employees จนหมดด้วยคำสั่ง length 
            {
                var grade = CalculetGrade(employees[i]);//เอาค่าที่ loop มาได้ทีล่ะตัวส่งเข้าไปใน method CalculetGrade เพื่อทำการคำนวนว่าได้เกรดอะไร แล้วเอาค่าที่ได้จาก method CalculetGrade ส่งค่ากลับมาไว้ในตัวแปร grade
                Console.WriteLine("Grade = " + grade);//แสดงผลออกทางหน้าจอ
            }
        }
        public string CalculetGrade(Employee employee)
        //สร้าง method ชื่อ CalculetGrade ค่าที่รับเข้ามาใน parameter คือค่าจาก Object ชื่อ employee
        {
            if (employee.Score > 80) return "A";
            else if (employee.Score > 70) return "B";
            else if (employee.Score > 60) return "C";
            else if (employee.Score > 50) return "D";
            else return "D";
            //เรียกใช้ฟิลด์ Score(ได้กำหนดค่าไว้แล้ว) จาก Object employee เอามาทำการเปรียบเทียบว่าได้เกรดอะไรแล้วจะทำการ retrun ค่าออกไปเป็น string
        }
    }
}

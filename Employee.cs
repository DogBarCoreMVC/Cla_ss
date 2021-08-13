using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cla_ss
{
    public class Employee
    {
        public string EmployeeCode { get; set; }
        //กำหนดฟิลด์ชื่อ EmployeeCode dataType เป็น string
        //กำหนดให้ get คือเอาค่าที่อยู่ใน EmployeeCode ออกไปใช้งานได้
        //กำหนดให้ set คือสามารถกำหนดค่าให้ EmployeeCode ได้
        public double Score { get; set; }
        //กำหนดฟิลด์ชื่อ Score dataType เป็น double
        //กำหนดให้ get คือเอาค่าที่อยู่ใน Score ออกไปใช้งานได้
        //กำหนดให้ set คือสามารถกำหนดค่าให้ Score ได้
    }
}

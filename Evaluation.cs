using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cla_ss
{
    class Evaluation
    {

        public string CalculateGrade(Employee employee)//Menthod Overlonding
        {
            if (employee.Score > 90) return "A";
            else if (employee.Score > 80) return "B";
            else if (employee.Score > 70) return "C";
            else if (employee.Score > 60) return "D";
            else return "F";
        }
    }
}

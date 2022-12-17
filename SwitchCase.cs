using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class SwitchCase
    {

        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public static void CaseSwitch()
        {
            int Emp_Rate_Per_Hour = 20;
            int Empwage;
            int Emphours;

            Random random = new Random();
            int empcheck = random.Next(3);


            switch (empcheck)
            {
                case Is_Full_Time:
                    Emphours = 8;
                    break;

                case Is_Part_Time:
                    Emphours = 4;
                    break;

                default:
                    Emphours = 0;
                    break;
            }

                    Empwage = Emphours * Emp_Rate_Per_Hour;
                    Console.WriteLine("Daily employee wage is : " + Empwage);
            
        }
    }
}

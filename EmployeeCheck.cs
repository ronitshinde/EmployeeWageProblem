﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeCheck
    {
        public static void EmployeeAttendance()
        {
            int Is_Full_Time = 1;

            Random random = new Random();
            int empcheck = random.Next(2);

            if (empcheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
                 
    }
}

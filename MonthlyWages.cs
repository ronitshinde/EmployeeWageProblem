﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class MonthlyWages
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 20;


        public static void EmpMonthWages()
        {

            int Empwage;
            int Emphours;
            int TotalEmpwage = 0;

            for (int day = 0; day < Num_Of_Working_Days; day++)
            {
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
                TotalEmpwage = TotalEmpwage + Empwage;
                Console.WriteLine("Daily employee wage is : " + Empwage);
            }

            Console.WriteLine("Tota Emp wage : " + TotalEmpwage);


        }
    }
}
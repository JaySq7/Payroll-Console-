using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSProject
{
    class Payslip
    {
        private int month;
        private int year;
        enum MonthsOfYear { JAN, FEB, MARCH, APRILL, MAY, JUNE, JULY, AUG, SEP, OCT, NOV, DEC };

        public Payslip(int payMonth, int payYear)
        {
            month = payMonth;
            year = payYear;
        }

        public void GeneratePaySlip(List<Staff> MyStaff)
        {
            string path;
            foreach (Staff f in MyStaff)
            {
                path = f.NameOfStaff + ".txt";
                
                using (StreamWriter sw = new StreamWriter(path))
                {

                }
            }
        }

    }
}

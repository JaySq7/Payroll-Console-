using System;
using System.Collections.Generic;
using System.Text;

namespace CSProject
{
    class Manager : Staff
    {
        private const float managerHourlyRate = 50;

        public int Allowance
        { get; private set; }

        public Manager(string name) : base(name, managerHourlyRate)
        {
          
        
        }

        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowance = 1000;
            
            if(HoursWorked > 160)
            {
                TotalPay = Allowance + TotalPay;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }



    } 
}

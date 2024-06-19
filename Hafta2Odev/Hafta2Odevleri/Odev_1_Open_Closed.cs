using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Odevleri
{
    interface ISavingAccount
    {
        //Other method and property and code
        decimal CalculateInterest();
    }
    public class RegularSavingAccount : ISavingAccount
    {
        //Other method and property and code related to Regular Saving account
        public decimal CalculateInterest()
        {
            //Calculate interest for regular saving account based on rules and
            // regulation of bank
            decimal balance = 1000;
            var amount = 5000;
            decimal interest = balance * 0.4m;
            if (balance < 1000) interest -= balance * 0.2m;
            if (balance < 50000) interest += amount * 0.4m;

            return interest;
        }
    }

    public class SalarySavingAccount : ISavingAccount
    {
        //Other method and property and code related to Salary Saving account`
        public decimal CalculateInterest()
        {
            //Calculate interest for saving account based on rules and regulation of
            //bank
            var balance = 1000;
            var interest = balance * 0.5m;
            return interest;
        }
    }
}

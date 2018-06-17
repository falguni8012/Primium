using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication2.Interface;

namespace MvcApplication2.Service
{
    public class PremiumFemaleService : IPremium
    {
        public double CalculatePremimun(int age)
        {

            double premium = 0;
            try
            {
                //TO-DO BUSINESS LOGIC GOES HERE
                premium = age * GlobalStatic.FEMALE_FACTOR * 100;               

            }
            catch (Exception)
            {

                //In this application this is the lowest layer so exception should be logged in here in persistent storage
                //Throwing the exception back to calling method..end user should not see the system exception rather they should see custom error message
                throw;
            }
            return premium;
        }
    }
}
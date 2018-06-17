using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication2.Interface;
using MvcApplication2.Factory;

namespace MvcApplication2.Service
{
    public class HomeService 
    {

        public double CalculatePremimun(int gender, int age)
        {
                       
            try
            {
                var service = PremiumFactory.GetInstance(gender);
                var prem = service.CalculatePremimun(age);
                return prem;
            }
            catch (Exception)
            {
                
                //In this application this is the lowest layer so exception should be logged in here in persistent storage
                //Throwing the exception back to calling method..end user should not see the system exception rather they should see custom error message
                throw;
            }
            
        }
    }
}